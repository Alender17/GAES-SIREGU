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
    public partial class frmagregartipo : Form
    {
        frmmantenimiento frm = new frmmantenimiento();
        clstipomantenimiento addtm = new clstipomantenimiento();
        public bool update = false;

        public frmagregartipo()
        {
            InitializeComponent();
            llenardtg();
            omacolum();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

   
        public void llenardtg()
        {
            dgtipomantenimiento.DataSource = addtm.mostrartiposm();
        }
        
        private void dgtipomantenimiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgtipomantenimiento.Rows[e.RowIndex].Cells["editar"].Selected)
            {
                update = true;
                txtid.Text = dgtipomantenimiento.CurrentRow.Cells[1].Value.ToString();
                txtdesc.Text = dgtipomantenimiento.CurrentRow.Cells[2].Value.ToString();
            }          
        }

        public void omacolum()
        {
            dgtipomantenimiento.Columns["editar"].DisplayIndex = 2;
            dgtipomantenimiento.Columns["editar"].Width = 40;
            dgtipomantenimiento.Columns[0].Width = 90;
            dgtipomantenimiento.Columns[1].Width = 90;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (update == false)
            {
                addtm.addtm(txtdesc.Text);
                this.Hide();
                frmnoti1.confirmacion("GUARDADO");
                frm.llenarcbo();
            }
            else if (update == true)
            {
                try
                {
                    addtm.updatetm((int.Parse(txtid.Text)), txtdesc.Text);
                    txtid.Clear();
                    txtdesc.Clear();
                    frmnoti1.confirmacion("MODIFICADO");
                    llenardtg();
                    frm.llenarcbo();
                    this.Close();
                }
                catch (Exception a)
                {
                    frmnoti1.confirmacion("MODIFICADO");
                }
            }
        }
    }
}
