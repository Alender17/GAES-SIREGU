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
    public partial class frmvehiculo : Form
    {
        public frmvehiculo()
        {
            InitializeComponent();
        }

        private void txtmatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmatricula.Text.Length != 6) throw new ArgumentException("Debe tener 6 digitos");

                int iNumeros = 0;

                foreach (char c in txtmatricula.Text)
                {
                    switch (c)
                    {
                        case '0': iNumeros++; break;
                        case '1': iNumeros++; break;
                        case '2': iNumeros++; break;
                        case '3': iNumeros++; break;
                        case '4': iNumeros++; break;
                        case '5': iNumeros++; break;
                        case '6': iNumeros++; break;
                        case '7': iNumeros++; break;
                        case '8': iNumeros++; break;
                        case '9': iNumeros++; break;
                    }
                }
                if (iNumeros != 3) throw new ArgumentException("Debe tener 3 numeros");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
