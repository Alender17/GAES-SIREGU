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
    public partial class frmnoti3 : Form
    {
        public frmnoti3(string mensaje)
        {
            InitializeComponent();
            Lblm.Text = mensaje;
        }

        private void btacep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void aviso(string mensaje)
        {
            frmnoti3 frm = new frmnoti3(mensaje);
            frm.ShowDialog();


        }
    }
}
