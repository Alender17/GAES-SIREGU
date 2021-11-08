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
using GAES_SIREGU.controlador;


namespace GAES_SIREGU.vista
{
    public partial class frmmantenimiento : Form
    {
        public frmmantenimiento()
        {
            InitializeComponent();
            llenarcbo();
        }

        private void addtipo_Click(object sender, EventArgs e)
        {
            frmagregartipo addtipo = new frmagregartipo();
            addtipo.Show();
        }

        private void frmmantenimiento_Load(object sender, EventArgs e)
        {
            llenarcbo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnguardarman_Click(object sender, EventArgs e)
        {

        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            frmagregartipo addtipo = new frmagregartipo();
            addtipo.Show();
        }

        private void cbotipoman_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public void llenarcbo()
        {
            clstipomantenimiento addtm = new clstipomantenimiento();
            cbotipoman.DataSource = addtm.mostrartiposm();
            cbotipoman.DisplayMember = "descripcion";
            cbotipoman.ValueMember = "id";
            if (cbotipoman.Items.Count > 1)
            {
                cbotipoman.SelectedIndex = -1;
            }
        }

        private void cbotipoman_Click(object sender, EventArgs e)
        {
            llenarcbo();
        }

        private void cbotipoman_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cbotipoman_Click_1(object sender, EventArgs e)
        {
            llenarcbo();
        }
    }
}
