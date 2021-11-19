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
    public partial class frmclientes : Form
    {
        clsclientes _clsclientes = new clsclientes();
        
        public bool update = false;

        public frmclientes()
        {
            InitializeComponent();
            llenardtg();
            llenarcbo();
        }

        private void frmclientes_Load(object sender, EventArgs e)
        {
            llenardtg();
            llenarcbo();
            omacolum();
            btguardar.Enabled = false;
        }

        private void cleanup()
        {
            txtnit.Focus();
            txtnit.Clear();
            txtnombre.Clear();
            txtdirecc.Clear();
            txttelefono.Clear();
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
             if (update == false)
            {
                try
                {
                    _clsclientes.AgregarClientes(txtnit.Text, txtnombre.Text, txtdirecc.Text, txttelefono.Text, Convert.ToInt32(cboruta.SelectedValue));
                    frmnoti1.confirmacion("GUARDADO");
                    llenardtg();
                    llenarcbo();
                    cleanup();
                }
                catch (Exception)
                {
                    frmnoti3.aviso("NO SE PUEDE GUARDAR");
                }
            }
            else if(update == true)
            {
                try
                {
                    _clsclientes.UpdateClientes(txtnit.Text, txtnombre.Text, txtdirecc.Text, txttelefono.Text, Convert.ToInt32(cboruta.SelectedValue));
                    llenarcbo();
                    cleanup();
                    llenardtg();
                    dgvclientes.ClearSelection();
                    frmnoti1.confirmacion("MODIFICADO");
                    update = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                    //frmnoti3.aviso("NO SE PUEDE MODIFICAR");
                }
            }
        }
        private void dgvclientes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvclientes.Rows[e.RowIndex].Cells["eliminar"].Selected)
            {
                DialogResult Resultado = new DialogResult();
                frmnoti2 frm = new frmnoti2("¿ESTAS SEGURO\n DE ELIMINAR EL \nCLIENTE?");

                Resultado = frm.ShowDialog();
                if (Resultado == DialogResult.OK)
                {
                    string delete = (dgvclientes.Rows[e.RowIndex].Cells[2].Value.ToString());
                    _clsclientes.deleteClientes(delete);
                    frmnoti1.confirmacion("ELIMINADO");
                    llenardtg();
                    cleanup();
                }
            }
            else if (dgvclientes.Rows[e.RowIndex].Cells["editar"].Selected)
            {
                update = true;
                txtnit.Text = dgvclientes.CurrentRow.Cells[2].Value.ToString();
                txtnombre.Text = dgvclientes.CurrentRow.Cells[3].Value.ToString();
                txtdirecc.Text = dgvclientes.CurrentRow.Cells[4].Value.ToString();
                txttelefono.Text = dgvclientes.CurrentRow.Cells[5].Value.ToString();
                cboruta.Text = dgvclientes.CurrentRow.Cells[6].Value.ToString();
            }

        }

        private void llenarcbo()
        {
           cboruta.DataSource=_clsclientes.mostrarRutas();
            cboruta.DisplayMember = "descripcion";
            cboruta.ValueMember = "id";
            if (cboruta.Items.Count > 1)
            {
                cboruta.SelectedIndex = -1;
            }
        }

        public void llenardtg()
        {
            dgvclientes.DataSource = _clsclientes.MostrarClientes();
        }

        public void omacolum()
        {
            dgvclientes.Columns[0].DisplayIndex = 6;
            dgvclientes.Columns[1].DisplayIndex = 6;

            dgvclientes.Columns["editar"].Width = 40;
            dgvclientes.Columns["eliminar"].Width = 40;
            dgvclientes.Columns[1].Width = 90;
            dgvclientes.Columns[2].Width = 90;
            dgvclientes.Columns[3].Width = 120;
            dgvclientes.Columns[4].Width = 90;
            dgvclientes.Columns[5].Width = 90;

        }

        private void actboton()
        {
            if ((txtnombre.Text != "") && (txtnit.Text != "") && (txttelefono.Text != "") && (txtdirecc.Text != "") && (cboruta.Text != null)) btguardar.Enabled = true;
            else btguardar.Enabled = false;
        }

        private void txtnit_TextChanged(object sender, EventArgs e)
        {
            actboton();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            actboton();
        }

        private void cboruta_SelectedIndexChanged(object sender, EventArgs e)
        {
            actboton();
        }

        private void txtdirecc_TextChanged(object sender, EventArgs e)
        {
            actboton();
        }

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {
            actboton();
        }

        clsvalidaciones v = new clsvalidaciones();

        private void txtnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }
    }
}
