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
    public partial class frmvehiculo : Form
    {
        clsvehiculos objVehiculos = new clsvehiculos();
        public bool update = false;

        public frmvehiculo()
        {
            InitializeComponent();
        }

        private void frmvehiculo_Load(object sender, EventArgs e)
        {
            LlenarTablaVehiculos();
            omacolum();

            //  DataGridViewImageColumn img = new DataGridViewImageColumn();
            //Image image = Image.FromFile("C:\\Users\\Acer\\source\\repos\\Prototipo\\Prototipo\\Resources\\anadir.png");
            //img.Image = image;
            //dgvVehiculos.Columns.Add(img);

            //img.HeaderText = "Eliminar";
            //img.Name = "img";

            //DataGridViewImageColumn img2 = new DataGridViewImageColumn();
            //Image image2 = Image.FromFile("C:\\Users\\Acer\\source\\repos\\Prototipo\\Prototipo\\Resources\\anadir.png");
            //img2.Image = image2;

            //dgvVehiculos.Columns.Add(img2);
            //img2.HeaderText = "Editar";
            //img2.Name = "img";
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

        private void LimpiarCampos()
        {
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtMotor.Text = "";
            txtMatricula.Text = "";
            lblRutaImagen.Text = "";
            dtTecno.Value = DateTime.Today;
            dtSoat.Value = DateTime.Today;
            subirimagen.ImageLocation = "C:\\Users\\aleng\\Downloads\\galeria (1).png";
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (update == false)
            {
                try
                {
                    if (objVehiculos.InsertarVehiculo(txtMatricula.Text, int.Parse(txtModelo.Text), int.Parse(txtMotor.Text), lblRutaImagen.Text, txtMarca.Text, dtSoat.Value, dtTecno.Value))
                    {
                        LlenarTablaVehiculos();
                        LimpiarCampos();
                        frmnoti1.confirmacion("VEHICULO GUARDADO");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR AL INSERTAR UN NUEVO VEHICULO, VALIDA LOS CAMPOS E INTENTA DE NUEVO", "SIGERU");
                }
            }
            else if (update == true)
            {
                try
                {
                    if (objVehiculos.EditarVehiculo(txtMatricula.Text, int.Parse(txtModelo.Text), int.Parse(txtMotor.Text), lblRutaImagen.Text, txtMarca.Text, dtSoat.Value, dtTecno.Value))
                    {
                        LlenarTablaVehiculos();
                        LimpiarCampos();
                        txtMatricula.Enabled = true;
                        frmnoti1.confirmacion("VEHICULO MODIFICADO");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR AL EDITAR ESTE VEHICULO", "SIGERU");
                }
            }











            //if (flag == 0)
            //{
            //    try
            //    {
            //        if (objVehiculos.InsertarVehiculo(txtMatricula.Text, int.Parse(txtModelo.Text), int.Parse(txtMotor.Text), lblRutaImagen.Text, txtMarca.Text, dtSoat.Value, dtTecno.Value))
            //        {
            //            LlenarTablaVehiculos();
            //            LimpiarCampos();
            //            MessageBox.Show("SE HA INSERTADO CORRECTAMENTE UN NUEVO VEHICULO");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("ERROR AL INSERTAR UN NUEVO VEHICULO, VALIDA LOS CAMPOS E INTENTA DE NUEVO", "SIGERU");
            //    }
            //}
            //else if (flag == 1)
            //{

            //    if (objVehiculos.EditarVehiculo(txtMatricula.Text, int.Parse(txtModelo.Text), int.Parse(txtMotor.Text), lblRutaImagen.Text, txtMarca.Text, dtSoat.Value, dtTecno.Value))
            //    {
            //        LlenarTablaVehiculos();
            //        LimpiarCampos();
            //        txtMatricula.Enabled = true;
            //        flag = 0; //  cambia a cero para que quede listo par guardar
            //        MessageBox.Show("SE HA EDITADO CORRECTAMENTE ESTE VEHICULO", "SIGERU");
            //    }
            //    else
            //    {
            //        MessageBox.Show("ERROR AL EDITAR ESTE VEHICULO", "SIGERU");
            //    }
            //}
        }

        public void omacolum()
        {
            dgvVehiculos.Columns[0].DisplayIndex = 8;
            dgvVehiculos.Columns[1].DisplayIndex = 8;
        }

        private void LlenarTablaVehiculos()
        {
            dgvVehiculos.DataSource = objVehiculos.BuscarVehiculos();
            dgvVehiculos.Columns[5].Visible = false;

        }

        private void dgvVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVehiculos.Rows[e.RowIndex].Cells["eliminar"].Selected)
            {
                DialogResult Resultado = new DialogResult();
                frmnoti2 frm = new frmnoti2("¿ESTAS SEGURO\n DE ELIMINAR EL \nVEHICULO?");

                Resultado = frm.ShowDialog();
                if (Resultado == DialogResult.OK)
                {
                    string delete = (dgvVehiculos.Rows[e.RowIndex].Cells[2].Value.ToString());
                    objVehiculos.EliminarVehiculo(delete);
                    frmnoti1.confirmacion("ELIMINADO");
                    LlenarTablaVehiculos();
;                   LimpiarCampos();
                }
            }
            else if (dgvVehiculos.Rows[e.RowIndex].Cells["editar"].Selected)
            {
                update = true;
                txtMatricula.Enabled = false;
                txtMatricula.Text = dgvVehiculos.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMotor.Text = dgvVehiculos.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtModelo.Text = dgvVehiculos.Rows[e.RowIndex].Cells[4].Value.ToString();
                subirimagen.ImageLocation = dgvVehiculos.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtMarca.Text = dgvVehiculos.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }
    }
}
