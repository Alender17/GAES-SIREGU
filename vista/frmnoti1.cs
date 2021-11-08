using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAES_SIREGU.vista
{
    public partial class frmnoti1 : Form
    {
        public frmnoti1(string mensaje)
        {
            InitializeComponent();
            LblMensaje.Text = mensaje;
        }

        private void btacep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void confirmacion(string mensaje)
        {
            frmnoti1 frm = new frmnoti1(mensaje);
            frm.ShowDialog();
        }

        private void frmnoti1_Load(object sender, EventArgs e)
        {

        }
    }
}
