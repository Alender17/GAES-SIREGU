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
        clsrutas objRutas = new clsrutas();
        public frmrutas()
        {
            InitializeComponent();
        }

        private void frmrutas_Load(object sender, EventArgs e)
        {
            ConsultarRutas();
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
                if (objRutas.InsertarRuta(txtNomRuta.Text, int.Parse(txtKM.Text)))
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
    }
}
