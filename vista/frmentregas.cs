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
    public partial class frmentregas : Form
    {
        clsentregas objEntregas = new clsentregas();
        public frmentregas()
        {
            InitializeComponent();
        }

        private void frmentregas_Load(object sender, EventArgs e)
        {
            BuscarRutas();
            BuscarVehiculo();
            BuscarVendedor();
            BuscarAuxiliar();
        }

        private void BuscarRutas()
        {
            cbxRutas.DataSource = objEntregas.BuscarRutas();
            cbxRutas.DisplayMember = "descripcion";
            cbxRutas.ValueMember = "id";
        }

        private void BuscarVehiculo()
        {
            cbxVehiculo.DataSource = objEntregas.BuscarVehiculos();
            cbxVehiculo.DisplayMember = "matricula";
            cbxVehiculo.ValueMember = "matricula";
        }

        private void BuscarVendedor()
        {
            cbxVendedor.DataSource = objEntregas.BuscarVendedor();
            cbxVendedor.DisplayMember = "nombre";
            cbxVendedor.ValueMember = "cedula";
        }
        private void BuscarAuxiliar()
        {
            cbxAuxiliar.DataSource = objEntregas.BuscarAuxiliar();
            cbxAuxiliar.DisplayMember = "nombre";
            cbxAuxiliar.ValueMember = "cedula";
        }

        private void btnguardarman_Click(object sender, EventArgs e)
        {
            try
            {
                if (objEntregas.InsertarEntrega(dpFecha.Value, int.Parse(cbxRutas.SelectedValue.ToString()), int.Parse(txtKilometraje.Text), cbxVehiculo.SelectedValue.ToString(), int.Parse(cbxAuxiliar.SelectedValue.ToString()), int.Parse(cbxVendedor.SelectedValue.ToString())))
                {
                    MessageBox.Show("Insertado Correctamente");
                }
                else
                {
                    MessageBox.Show("Error al Insertar");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
          
        }
    }
}
