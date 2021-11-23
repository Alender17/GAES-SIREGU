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
    public partial class frmrutas : Form
    {
        clsvalidaciones v = new clsvalidaciones();
        clsrutas objRutas = new clsrutas();
        public frmrutas()
        {
            InitializeComponent();
        }

        private void frmrutas_Load(object sender, EventArgs e)
        {
            ConsultarRutas();
            btnguardar.Enabled = false;
            dgvRutas.Columns[0].Width = 60;
            dgvRutas.Columns[1].Width = 130;
            dgvRutas.Columns[2].Width = 100;
        }

        private void ConsultarRutas()
        {
            dgvRutas.DataSource = objRutas.ConsultarRutas();
        }

        private void limpiartxt()
        {
            txtKM.Clear();
            txtNomRuta.Clear();
            txtNomRuta.Focus();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            btnguardar.Enabled = false;
            btnguardar.Text = "...";

            if (txtNomRuta.Text != null && txtKM.Text != null)
            {
                if (objRutas.InsertarRuta(txtNomRuta.Text.ToUpper().Trim(), int.Parse(txtKM.Text.Trim())))
                {
                    ConsultarRutas();
                    frmnoti1.confirmacion("RUTA INSERTADA\n CORRECTAMENTE");
                    btnguardar.Enabled = true;
                    btnguardar.Text = "GUARDAR";
                    limpiartxt();
                }
                else
                {
                    frmnoti3.aviso("HUBO UN PROBLEMA \nAL INSERTAR LA RUTA");
                }
            }
        }
        
        private void activarboton()
        {
            if ((txtKM.Text != "") && (txtNomRuta.Text != "")) btnguardar.Enabled = true;
            else btnguardar.Enabled = false;
        }

        private void txtNomRuta_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtKM_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtNomRuta_TextChanged(object sender, EventArgs e)
        {
            activarboton();
        }

        private void txtKM_TextChanged(object sender, EventArgs e)
        {
            activarboton();
        }
    }
}
