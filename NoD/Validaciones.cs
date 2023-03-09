using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoD
{
    internal class Validaciones
    {
        public static bool Snumero(KeyPressEventArgs e)

        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.' || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }

        }
    }
}
