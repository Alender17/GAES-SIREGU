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
    public partial class frmprincipalmenu : Form
    {
        public frmprincipalmenu()
        {
            InitializeComponent();
        }

        private void btnslide_Click_1(object sender, EventArgs e)
        {
            if (menuvertical.Width == 202)
            {
                menuvertical.Width = 62;
            }
            else
            {
                menuvertical.Width = 202;
            }
        }

        private void nosubmenu()
        {
            panelboton.Visible = false;
        }

        public void abrirfrm(object frm)
        {
            if (this.panelcontenedor.Controls.Count > 0)
                this.panelcontenedor.Controls.RemoveAt(0);
            Form fh = frm as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();
        }

        private void btmantenimiento_Click(object sender, EventArgs e)
        {
            abrirfrm(new frmmantenimiento());
        }

        private void btnentregas_Click(object sender, EventArgs e)
        {
            abrirfrm(new frmentregas());
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            abrirfrm(new frmreportes());
        }

        private void btnparametros_Click(object sender, EventArgs e)
        {
            abrirfrm(new frmparametros());
        }

        private void btnvehiculos_Click(object sender, EventArgs e)
        {
            abrirfrm(new frmvehiculo());
        }

        private void btnempleados_Click(object sender, EventArgs e)
        {
            abrirfrm(new frmempleados());
        }

        private void btnrutas_Click(object sender, EventArgs e)
        {
            abrirfrm(new frmrutas());
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            abrirfrm(new frmclientes());
        }

        private void btajustes_Click(object sender, EventArgs e)
        {
            abrirfrm(new frmajustes());
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            frmnoti2 frm = new frmnoti2("¿ESTA SEGURO QUE DESEA CERRAR SECCION?");
            resultado = frm.ShowDialog();


            if (resultado == DialogResult.OK)
            {
                frmlogin login = new frmlogin();
                login.Show();
                this.Close();

            }
            else
            {

            }
        }

        private void btusuario_Click(object sender, EventArgs e)
        {

        }

        private void frmprincipalmenu_Load(object sender, EventArgs e)
        {
            nosubmenu();
        }

        private void close_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            frmnoti2 frm = new frmnoti2("¿ESTAS SEGURO QUE DESEA SALIR DEL SISTEMA?");
            resultado = frm.ShowDialog();


            if (resultado == DialogResult.OK)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void minizar_Click(object sender, EventArgs e)
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

        private void btusuario_Click_1(object sender, EventArgs e)
        {
            if (panelboton.Visible == false)
            {
                panelboton.Visible = true;
            }
            else
            {
                panelboton.Visible = false;
            }
        }
    }
}
