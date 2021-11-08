using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GAES_SIREGU.controlador;

namespace GAES_SIREGU.vista
{
    public partial class frmolvidarcontrasena : Form
    {
        public frmolvidarcontrasena()
        {
            InitializeComponent();
        }

        clslogin objLogin = new clslogin();

        private void btrestablecer_Click(object sender, EventArgs e)
        {
            btrestablecer.Text = "...";
            btrestablecer.Enabled = false;

            string nuevaContra = objLogin.GenerarContraseñaSegura();
            string nuevaContraSHA = objLogin.GetSHA256(nuevaContra);
            try
            {
                if (objLogin.RestablecerContra(txtCorreoR.Text, txtUsuarioR.Text, nuevaContraSHA))
                {
                    if (objLogin.EnviarCorreo(txtCorreoR.Text, nuevaContra))
                    {
                        MessageBox.Show("SE HA ENVIADO UN CORREO CON TU NUEVA CONTRASEÑA");
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo crear una nueva contraseña para usted, por favor valide sus datos e intente de nuevo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            btrestablecer.Text = "RESTABLECER";
            btrestablecer.Enabled = true;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
