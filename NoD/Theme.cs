using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoD
{
    public static class Theme
    {
        public static void ApplyDarkTheme(Control control)
        {
            control.BackColor = Color.FromArgb(30, 30, 30);
            control.ForeColor = Color.White;

            if (control is Button)
            {
                ((Button)control).FlatStyle = FlatStyle.Flat;
                ((Button)control).FlatAppearance.BorderColor = Color.DarkGray;
                ((Button)control).FlatAppearance.MouseDownBackColor = Color.DimGray;
                ((Button)control).FlatAppearance.MouseOverBackColor = Color.Gray;
            }

            foreach (Control childControl in control.Controls)
            {
                ApplyDarkTheme(childControl);
            }
        }
        public static void ApplyLightTheme(Control control)
        {
            control.BackColor = SystemColors.Control;
            control.ForeColor = SystemColors.ControlText;

            if (control is Button)
            {
                ((Button)control).FlatStyle = FlatStyle.Standard;
                ((Button)control).FlatAppearance.BorderColor = SystemColors.ActiveBorder;
                ((Button)control).FlatAppearance.MouseDownBackColor = SystemColors.ControlDark;
                ((Button)control).FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            }

            foreach (Control childControl in control.Controls)
            {
                ApplyLightTheme(childControl);
            }
        }
    }
}
