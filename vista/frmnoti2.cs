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
    public partial class frmnoti2 : Form
    {
        public frmnoti2(string mensaje)
        {
            InitializeComponent();
            Lblm.Text = mensaje;
        }

        private void Btcancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btacep_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
