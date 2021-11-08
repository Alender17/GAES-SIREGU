using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GAES_SIREGU.modelo;

namespace GAES_SIREGU.vista
{
    public partial class frmempleados : Form
    {
        public frmempleados()
        {
            InitializeComponent();
        }

        public void listar()
        {
            using (DBSIGERUEntities db = new DBSIGERUEntities())
            {
                var listar = db.tipoEmpleado.ToList();
                if (listar.Count > 0)
                {
                    cbotempleado.DataSource = listar;
                    cbotempleado.DisplayMember = "descripcion";
                    cbotempleado.ValueMember = "id";
                    if (cbotempleado.Items.Count > 1)
                    {
                        cbotempleado.SelectedIndex = -1;
                    }
                }

            }
        }

        private void frmempleados_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void cbotempleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
