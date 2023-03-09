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
    public partial class Ganancia_neta : Form
    {
        public Ganancia_neta()
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
    
        private void Ganancia_neta_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Validaciones
            string SMCU = textBox1.Text;
            string SCU = textBox2.Text;
            string SPE = textBox3.Text;

            if (SMCU.Length == 0 || SCU.Length == 0 || SPE.Length == 0)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                label15.Text = "";
                MessageBox.Show("Ingrese todos los datos requeridos");
            }
            else
            {
                decimal MCU = Convert.ToDecimal(SMCU);
                decimal CU = Convert.ToDecimal(SCU);
                decimal PE = Convert.ToDecimal(SPE);

                decimal GN = (MCU * CU) - (PE * MCU);

                string StringGN = Convert.ToString(GN);
                label15.Text = StringGN;
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            string c1 = textBox2.Text;


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
                    textBox2.Text = textBox2.Text + ",";
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string c1 = textBox3.Text;


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
                    textBox3.Text = textBox3.Text + ",";
                }

            }
        }

        ErrorProvider errorP0 = new ErrorProvider();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.ShortcutsEnabled = false;
            bool valida = Validaciones.Snumero(e);
            if (!valida)
                errorP0.SetError(textBox1, "Solo números");
            else
                errorP0.Clear();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.ShortcutsEnabled = false;
            bool valida = Validaciones.Snumero(e);
            if (!valida)
                errorP0.SetError(textBox1, "Solo números");
            else
                errorP0.Clear();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.ShortcutsEnabled = false;
            bool valida = Validaciones.Snumero(e);
            if (!valida)
                errorP0.SetError(textBox1, "Solo números");
            else
                errorP0.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {

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
        private bool isDarkTheme = false;
        private void button6_Click(object sender, EventArgs e)
        {
            ToggleTheme();
        }
    }
}
