using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GAES_SIREGU.vista;

namespace GAES_SIREGU.controlador
{
    public class clsvalidaciones
    {
        public void SoloNumeros(KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                frmnoti3.aviso("SOLO NÚMEROS");
            }
        }

        public void SoloLetras(KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                frmnoti3.aviso("SOLO LETRAS");
            }
        }
    }
}
