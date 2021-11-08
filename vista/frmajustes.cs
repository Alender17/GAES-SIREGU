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
    public partial class frmajustes : Form
    {
        clslogin objLogin = new clslogin();

        public frmajustes()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string usuario = "admin";

            if (txtContraAnt.Text != "" && txtContraNue.Text != "")
            {
                if (objLogin.editarContraseña(usuario, txtContraAnt.Text, txtContraNue.Text))
                {
                    MessageBox.Show("Contraseña Cambiada Correctamente");
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos");
                }
            }
        }

        private void frmajustes_Load(object sender, EventArgs e)
        {

        }

        private void btnguardarusu_Click(object sender, EventArgs e)
        {
            string usuario = "admin";

            if (txtContraAnt.Text != "" && txtContraNue.Text != "")
            {
                if (objLogin.editarContraseña(usuario, txtContraAnt.Text, txtContraNue.Text))
                {
                    MessageBox.Show("Contraseña Cambiada Correctamente");
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos");
                }
            }
        }
    }
}
