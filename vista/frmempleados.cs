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
    public partial class frmempleados : Form
    {
        clsempleados _empleados = new clsempleados();
        clsvalidaciones v = new clsvalidaciones();

        public bool update = false;
        public frmempleados()
        {
            InitializeComponent();
        }

        public void listar()
        {
            cbotempleado.DataSource = _empleados.tipoEmpleado();
            cbotempleado.DisplayMember = "descripcion";
            cbotempleado.ValueMember = "id";
            if (cbotempleado.Items.Count > 1)
            {
                cbotempleado.SelectedIndex = -1;
            }

            cbovehiculo.DataSource = _empleados.vehiculos();
            cbovehiculo.DisplayMember = "matricula";
            cbovehiculo.ValueMember = "matricula";
            if (cbovehiculo.Items.Count > 1)
            {
                cbovehiculo.SelectedIndex = -1;
            }

        }

        public void llenardtg()
        {
            dgvempleados.DataSource = _empleados.Mostrar();
            medidasdtgv(); 
        }

        private void cleanup()
        {
            txtcedula.Focus();
            txtcedula.Clear();
            txtnombre.Clear();
            txtdirec.Clear();
            txttelef.Clear();
            txttipos.Clear();
            txtcorreo.Clear();
            subirimagen.ImageLocation = "C:\\Users\\aleng\\Downloads\\galeria (1).png";
        }

        private void frmempleados_Load(object sender, EventArgs e)
        {
            listar();
            llenardtg();
            rbHabilitado.Checked = false;
            rdDeshab.Checked = false;
        }

        int Estado;
        private void radiob()
        {
            if(rbHabilitado.Checked == true)
            {
                Estado = 0;
            }
            else if(rdDeshab.Checked == true)
            {
                Estado = 1;
            }
        }

        private void medidasdtgv()
        {
            dgvempleados.Columns[5].Visible = false;
            dgvempleados.Columns[0].DisplayIndex = 11;
            dgvempleados.Columns[1].DisplayIndex = 11;

            dgvempleados.Columns[2].Width = 90;//cedula
            dgvempleados.Columns[3].Width = 120;//nombre
            dgvempleados.Columns[4].Width = 120;//direccion
            dgvempleados.Columns[6].Width = 130;//correo
            dgvempleados.Columns[7].Width = 90;//telefono
            dgvempleados.Columns[8].Width = 35;//tipo de sangre
            dgvempleados.Columns[9].Width = 35;//tipo de empleado
            dgvempleados.Columns[10].Width = 80;//matricula
            dgvempleados.Columns[11].Width = 35;//estado
        }

        private void color()
        {
            foreach (DataGridViewRow data in dgvempleados.Rows)
            {
                if (data.Cells[11].Value.ToString() == "1")
                {
                    data.Cells["editar"].Style.BackColor = Color.FromArgb(255, 128, 128);
                    data.Cells["eliminar"].Style.BackColor = Color.FromArgb(255, 128, 128);
                    data.Cells[2].Style.BackColor = Color.FromArgb(255, 128, 128);
                    data.Cells[3].Style.BackColor = Color.FromArgb(255, 128, 128);
                    data.Cells[4].Style.BackColor = Color.FromArgb(255, 128, 128);
                    data.Cells[6].Style.BackColor = Color.FromArgb(255, 128, 128);
                    data.Cells[7].Style.BackColor = Color.FromArgb(255, 128, 128);
                    data.Cells[8].Style.BackColor = Color.FromArgb(255, 128, 128);
                    data.Cells[9].Style.BackColor = Color.FromArgb(255, 128, 128);
                    data.Cells[10].Style.BackColor = Color.FromArgb(255, 128, 128);
                    data.Cells[11].Style.BackColor = Color.FromArgb(255, 128, 128);

                    data.Cells[2].Style.ForeColor = Color.Black;
                    data.Cells[3].Style.ForeColor = Color.Black;
                    data.Cells[4].Style.ForeColor = Color.Black;
                    data.Cells[6].Style.ForeColor = Color.Black;
                    data.Cells[7].Style.ForeColor = Color.Black;
                    data.Cells[8].Style.ForeColor = Color.Black;
                    data.Cells[9].Style.ForeColor = Color.Black;
                    data.Cells[10].Style.ForeColor = Color.Black;
                    data.Cells[11].Style.ForeColor = Color.Black;
                }
                else
                {
                    data.Cells[2].Style.BackColor = Color.White;
                    data.Cells[3].Style.BackColor = Color.White;
                    data.Cells[4].Style.BackColor = Color.White;
                    data.Cells[6].Style.BackColor = Color.White;
                    data.Cells[7].Style.BackColor = Color.White;
                    data.Cells[8].Style.BackColor = Color.White;
                    data.Cells[9].Style.BackColor = Color.White;
                    data.Cells[10].Style.BackColor = Color.White;
                    data.Cells[11].Style.BackColor = Color.White;
                }
            }
        }


        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (update == false)
            {
                try
                {
                    radiob();
                    _empleados.AgregarEmpleados(Convert.ToInt32(txtcedula.Text), txtnombre.Text, txtdirec.Text, lblRutaImagen.Text, txtcorreo.Text, txttelef.Text, txttipos.Text, Convert.ToInt32(cbotempleado.SelectedValue.ToString()), cbovehiculo.SelectedValue.ToString(), Estado); 
                    frmnoti1.confirmacion("GUARDADO");
                    llenardtg();
                    listar();
                    cleanup();
                }
                catch (Exception)
                {
                    frmnoti3.aviso("NO SE PUEDE GUARDAR");
                }
            }
            else if (update == true)
            {
                try
                {
                    radiob();
                    _empleados.EditarEmpleados(Convert.ToInt32(txtcedula.Text), txtnombre.Text, txtdirec.Text, lblRutaImagen.Text, txtcorreo.Text, txttelef.Text, txttipos.Text, Convert.ToInt32(cbotempleado.SelectedValue.ToString()), cbovehiculo.SelectedValue.ToString(), Estado);
                    llenardtg();
                    cleanup();
                    listar();
                    frmnoti1.confirmacion("MODIFICADO");
                    update = false;
                    txtcedula.Enabled = true;
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void dgvempleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvempleados.Rows[e.RowIndex].Cells["eliminar"].Selected)
            {
                DialogResult Resultado = new DialogResult();
                frmnoti2 frm = new frmnoti2("¿ESTAS SEGURO\n DE ELIMINAR EL \nEMPLEADO?");

                Resultado = frm.ShowDialog();
                if (Resultado == DialogResult.OK)
                {
                    string delete = (dgvempleados.Rows[e.RowIndex].Cells[2].Value.ToString());
                    _empleados.eliminarEmleado(Convert.ToInt32(delete));
                    frmnoti1.confirmacion("ELIMINADO");
                    llenardtg();
                    cleanup();
                }
            }
            else if (dgvempleados.Rows[e.RowIndex].Cells["editar"].Selected)
            {
                update = true;
                txtcedula.Enabled = false;
                txtcedula.Text = dgvempleados.CurrentRow.Cells[2].Value.ToString();
                txtnombre.Text = dgvempleados.CurrentRow.Cells[3].Value.ToString();
                txtdirec.Text = dgvempleados.CurrentRow.Cells[4].Value.ToString();
                txtcorreo.Text = dgvempleados.CurrentRow.Cells[6].Value.ToString();
                txttelef.Text = dgvempleados.CurrentRow.Cells[7].Value.ToString();
                txttipos.Text = dgvempleados.CurrentRow.Cells[8].Value.ToString();
                if (dgvempleados.CurrentRow.Cells[9].Value.ToString() == "1")
                {
                    cbotempleado.SelectedIndex = 0;
                }
                if (dgvempleados.CurrentRow.Cells[9].Value.ToString() == "2")
                {
                    cbotempleado.SelectedIndex = 1;
                }
                //cbotempleado.Text = dgvempleados.CurrentRow.Cells[9].Value.ToString();
                cbovehiculo.SelectedValue = dgvempleados.CurrentRow.Cells[10].Value.ToString();
                if (dgvempleados.CurrentRow.Cells[11].Value.ToString() == "0")
                {
                    rbHabilitado.Checked = true;
                }
                else
                {
                    rdDeshab.Checked = true;
                }

            }
        }

        private void dgvempleados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            color();
        }

        private void subirimagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                subirimagen.ImageLocation = openFileDialog1.FileName;
                lblRutaImagen.Text = openFileDialog1.FileName;
            }
        }

        private void txtcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txttelef_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }
    }
}
