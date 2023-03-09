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
    public partial class Estadisticas_descriptivas : Form
    {
        List<decimal> numeros = new List<decimal>();
        public Estadisticas_descriptivas()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        ErrorProvider errorP0 = new ErrorProvider();
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox2.ShortcutsEnabled = false;
            bool valida = Validaciones.Snumero(e);
            if (!valida)
                errorP0.SetError(textBox2, "Solo números");
            else
                errorP0.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal numero;

            if (decimal.TryParse(textBox2.Text, out numero))
            {
                numeros.Add(numero);
                decimal suma = numeros.Sum();
                label4.Text = suma.ToString();
                textBox2.Text = "";
                decimal maximo = numeros.Max();
                decimal minimo = numeros.Min();
                decimal promedio = numeros.Average();
                label9.Text = maximo.ToString("0.000");
                label10.Text = minimo.ToString("0.000");
                label11.Text = promedio.ToString("0.000");
            }
            else
            {
                MessageBox.Show("Ingrese un número válido");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string c1 = textBox2.Text;
            string[] subcadenas1 = c1.Split(',');

            if (subcadenas1.Length > 1 || c1.Length == 0)
            {
                MessageBox.Show("No valido");
            }
            else
            {
                textBox2.Text = textBox2.Text + ",";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            numeros.Clear();
            label4.Text = "--";
            label9.Text = "--";
            label10.Text = "--";
            label11.Text = "--";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void Estadisticas_descriptivas_Load(object sender, EventArgs e)
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
        private void button5_Click(object sender, EventArgs e)
        {
            ToggleTheme();
        }
    }
}
