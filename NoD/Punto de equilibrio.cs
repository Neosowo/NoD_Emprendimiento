using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NoD
{
    public partial class Punto_de_equilibrio : Form
    {

        public Punto_de_equilibrio()
        {
            InitializeComponent();
            if (AppSettings.IsDarkThemeEnabled)
            {
                Theme.ApplyDarkTheme(this);
            }
            else
            {
                Theme.ApplyLightTheme(this);
            }
        }
        private void ToggleTheme()
        {
            AppSettings.IsDarkThemeEnabled = !AppSettings.IsDarkThemeEnabled;

            if (AppSettings.IsDarkThemeEnabled)
            {
                Theme.ApplyDarkTheme(this);
            }
            else
            {
                Theme.ApplyLightTheme(this);
            }

            // Guardar el estado del tema
            // ...
        }
        private void Punto_de_equilibrio_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //PVU 
            textBox2.ShortcutsEnabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //ECF
            textBox3.ShortcutsEnabled = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //#u
            textBox4.ShortcutsEnabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            //Validaciones
            string SECV = textBox1.Text;
            string SECF = textBox2.Text;
            string SPVU = textBox3.Text;
            string SCP = textBox4.Text;
            if (SECV.Length == 0 || SECF.Length == 0 || SPVU.Length == 0 || SCP.Length == 0)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                MessageBox.Show("Ingrese todos los datos requeridos");
            }
            else
            {
                decimal ECV = Convert.ToDecimal(SECV);
                decimal ECF = Convert.ToDecimal(SECF);
                decimal PVU = Convert.ToDecimal(SPVU);
                decimal CU = Convert.ToDecimal(SCP);

                //MAGIA INSANA
                decimal CVU = ECV / CU;
                decimal MCU = PVU - CVU;

                decimal RPE, PE;
                PE = ECF / MCU;
                RPE = (int)Math.Floor(PE);

                if (radioButton1.Checked == true)
                {
                    string StringRPE = Convert.ToString(RPE);
                    label11.Text = StringRPE;
                }
                else if (radioButton2.Checked == true)
                {
                    string StringPE = Convert.ToString(PE);
                    label11.Text = StringPE;
                }


            }



        }


        ErrorProvider errorP0 = new ErrorProvider();
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ECV
            textBox1.ShortcutsEnabled = false;
            bool valida = Validaciones.Snumero(e);
            if (!valida)
                errorP0.SetError(textBox1, "Solo números");
            else
                errorP0.Clear();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ECF
            textBox2.ShortcutsEnabled = false;
            bool valida = Validaciones.Snumero(e);
            if (!valida)
                errorP0.SetError(textBox1, "Solo números");
            else
                errorP0.Clear();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //PVU
            textBox3.ShortcutsEnabled = false;
            bool valida = Validaciones.Snumero(e);
            if (!valida)
                errorP0.SetError(textBox1, "Solo números");
            else
                errorP0.Clear();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //CU
            textBox4.ShortcutsEnabled = false;
            bool valida = Validaciones.Snumero(e);
            if (!valida)
                errorP0.SetError(textBox1, "Solo números");
            else
                errorP0.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string c1 = textBox1.Text;


            string[] subcadenas1 = c1.Split(',');


            if (subcadenas1.Length > 1)
            {
                MessageBox.Show("No valido");
            }
            else if (c1.Length == 0)
            {
                MessageBox.Show("No valido");
            }
            else
            {
                if (button3.Enabled == true)
                {
                    textBox1.Text = textBox1.Text + ",";
                }

            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Obtener el contenido del portapapeles
                string clipboardText = Clipboard.GetText();

                // Verificar si el contenido es numérico
                double value;
                if (!double.TryParse(clipboardText, out value))
                {
                    // Cancelar la operación de pegado
                    e.Handled = true;
                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Obtener el contenido del portapapeles
                string clipboardText = Clipboard.GetText();

                // Verificar si el contenido es numérico
                double value;
                if (!double.TryParse(clipboardText, out value))
                {
                    // Cancelar la operación de pegado
                    e.Handled = true;
                }
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Obtener el contenido del portapapeles
                string clipboardText = Clipboard.GetText();

                // Verificar si el contenido es numérico
                double value;
                if (!double.TryParse(clipboardText, out value))
                {
                    // Cancelar la operación de pegado
                    e.Handled = true;
                }
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Obtener el contenido del portapapeles
                string clipboardText = Clipboard.GetText();

                // Verificar si el contenido es numérico
                double value;
                if (!double.TryParse(clipboardText, out value))
                {
                    // Cancelar la operación de pegado
                    e.Handled = true;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string c2 = textBox2.Text;


            string[] subcadenas2 = c2.Split(',');

            if (subcadenas2.Length > 1)
            {
                MessageBox.Show("No valido");
            }
            else if (c2.Length == 0)
            {
                MessageBox.Show("No valido");
            }
            else
            {
                if (button3.Enabled == true)
                {
                    textBox2.Text = textBox2.Text + ",";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string c3 = textBox3.Text;
            string[] subcadenas3 = c3.Split(',');

            if (subcadenas3.Length > 1)
            {
                MessageBox.Show("No valido");
            }
            else if (c3.Length == 0)
            {
                MessageBox.Show("No valido");
            }
            else
            {
                if (button3.Enabled == true)
                {
                    textBox3.Text = textBox3.Text + ",";
                }
            }

        }
        private void button6_Click(object sender, EventArgs e)
        {
            string c4 = textBox4.Text;
            string[] subcadenas4 = c4.Split(',');


            if (subcadenas4.Length > 1)
            {
                MessageBox.Show("No valido");
            }
            else if (c4.Length == 0)
            {
                MessageBox.Show("No valido");
            }
            else
            {
                if (button3.Enabled == true)
                {
                    textBox4.Text = textBox4.Text + ",";
                }
            }
        }
        private bool isDarkTheme = false;
        private void button7_Click(object sender, EventArgs e)
        {
            ToggleTheme();
        }
    }
}
