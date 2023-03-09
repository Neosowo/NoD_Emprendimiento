using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NoD
{
    public partial class Operaciones_matematicas : Form
    {
        private decimal valor1 = 0;
        private decimal respuesta = 0;
        private decimal valor2 = 0;

        private int op = 0;
        public Operaciones_matematicas()
        {
            InitializeComponent();
            this.BackColor = Color.White;
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

        private void Operaciones_matematicas_Load(object sender, EventArgs e)
        {
            Theme.ApplyDarkTheme(this);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //N 0
            textBox1.Text = textBox1.Text + "0";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //N 7
            textBox1.Text = textBox1.Text + "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //N 8
            textBox1.Text = textBox1.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //N 9
            textBox1.Text = textBox1.Text + "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //N 4
            textBox1.Text = textBox1.Text + "4";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //N 5
            textBox1.Text = textBox1.Text + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //N 6
            textBox1.Text = textBox1.Text + "6";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //N 1
            textBox1.Text = textBox1.Text + "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //N 2
            textBox1.Text = textBox1.Text + "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //N 3
            textBox1.Text = textBox1.Text + "3";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // ,
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


            /*            string c1 = textBox1.Text;


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

            }*/
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // =

            if (textBox1.TextLength > 0)
            {

                valor2 = Convert.ToDecimal(textBox1.Text);
                switch (op)
                {

                    case (1):
                        respuesta = valor1 + valor2;
                        break;

                    case (2):
                        respuesta = valor1 - valor2;
                        break;
                    case (3):
                        respuesta = valor1 * valor2;
                        break;
                    case (4):
                        respuesta = valor1 / valor2;
                        break;
                }

                if (valor1 == respuesta || valor2 == 0)
                {
                    textBox1.Text = valor1.ToString();
                }
                else
                {
                    textBox1.Text = respuesta.ToString("0.00");
                }
                decimal nc = Convert.ToDecimal(textBox1.TextLength);


            }
            else if (textBox1.TextLength == 0)
            {
                MessageBox.Show("Ingrese valores");
            }
            else if (textBox1.Text == "-")
            {
                MessageBox.Show("Ingrese valores");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OP +
            op = 1;
            valor1 = Convert.ToDecimal(textBox1.Text);

            textBox1.Text = "";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //OP -
            op = 2;


            valor1 = Convert.ToDecimal(textBox1.Text);



            textBox1.Text = "";



        }

        private void button3_Click(object sender, EventArgs e)
        {
            //OP *
            op = 3;
            valor1 = Convert.ToDecimal(textBox1.Text);

            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //OP /
            op = 4;
            valor1 = Convert.ToDecimal(textBox1.Text);

            textBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //boton clear
            textBox1.Text = "";
            valor1 = 0;
            respuesta = 0;
            valor2 = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Textbox de pantalla
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
        private bool isDarkTheme = false;
        private void button19_Click(object sender, EventArgs e)
        {
            ToggleTheme();
        }
    }
}
