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

    public partial class Facturacion : Form
    {
        List<decimal> numeros = new List<decimal>();
        public Facturacion()
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
        private void Facturacion_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
        ErrorProvider errorP0 = new ErrorProvider();
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.ShortcutsEnabled = false;
            bool valida = Validaciones.Snumero(e);
            if (!valida)
                errorP0.SetError(textBox1, "Solo números");
            else
                errorP0.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string c1 = textBox1.Text;
            string[] subcadenas1 = c1.Split(',');

            if (subcadenas1.Length > 1 || c1.Length == 0)
            {
                MessageBox.Show("No valido");
            }
            else
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal numero;

            if (decimal.TryParse(textBox1.Text, out numero))
            {
                numeros.Add(numero);
                decimal suma = numeros.Sum();
                label10.Text = suma.ToString();
                textBox1.Text = "";
                decimal iva = suma * 0.12m;
                label9.Text = iva.ToString();
                decimal rt = iva * 0.30m;
                label8.Text = rt.ToString();
                decimal tp = suma + iva;
                label6.Text = tp.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un número válido");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numeros.Clear();
            label6.Text = "--";
            label8.Text = "--";
            label9.Text = "--";
            label6.Text = "--";
        }
        private bool isDarkTheme = false;
        private void button5_Click(object sender, EventArgs e)
        {
            ToggleTheme();
        }

    }
}
