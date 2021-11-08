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
using GAES_SIREGU.vista;

namespace GAES_SIREGU
{
    public partial class frmlogin : Form
    {
        clslogin clslog = new clslogin();

        public frmlogin()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            ingreso();
        }

        private void ingreso()
        {
            bool permiso = clslog.encontraruser(txtuser.Text, txtpass.Text);
            if (permiso)
            {
                frmprincipalmenu frm = new frmprincipalmenu();
                this.Hide();
                frm.Show();
            }
            else
            {
                frmnoti3.aviso("Contraseña Incorrecta");
            }
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            btningresar.Enabled = false;
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Black;
                //txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.DarkGray;
                //txtpass.UseSystemPasswordChar = false;
            }
        }

        private void ver_Click(object sender, EventArgs e)
        {
            if (txtpass.PasswordChar == '*')
            {
                nover.BringToFront();
                txtpass.PasswordChar = '\0';
            }
        }

        private void nover_Click(object sender, EventArgs e)
        {
            if (txtpass.PasswordChar == '\0')
            {
                ver.BringToFront();
                txtpass.PasswordChar = '*';
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

        private void close_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            frmnoti2 frm = new frmnoti2("¿ESTAS SEGURO QUE DESEA SALIR DEL SISTEMA?");
            resultado = frm.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                Application.Exit();
                this.Hide();
            }
            else
            {

            }
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            if ((txtuser.Text != "") && (txtpass.Text != "")) btningresar.Enabled = true;
            else btningresar.Enabled = false;
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            if ((txtuser.Text != "") && (txtpass.Text != "")) btningresar.Enabled = true;
            else btningresar.Enabled = false;
        }

        private void lblolvidar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmolvidarcontrasena frm = new frmolvidarcontrasena();
            frm.Show();
        }
    }
}
