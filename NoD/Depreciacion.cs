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
    public partial class Depreciacion : Form
    {
        private int op = 0;

        public Depreciacion()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Depreciacion_Load(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0 && textBox2.TextLength > 0 && textBox3.TextLength > 0)
            {
                string SAC = textBox1.Text;
                int AC = Convert.ToInt32(SAC);
                string SAD = textBox3.Text;
                int AD = Convert.ToInt32(SAD);

                if (AC > AD || AC < 1000 || AD > 3000)
                {
                    MessageBox.Show("No valido");
                    textBox1.Text = ""; textBox3.Text = "";
                }
                else
                {
                    if (radioButton1.Checked)
                    {
                        op = 20;
                        Calculos_insanos(op, AC, AD);
                    }
                    else if (radioButton2.Checked)
                    {
                        op = 10;
                        Calculos_insanos(op, AC, AD);
                    }
                    else if (radioButton3.Checked)
                    {
                        op = 5;
                        Calculos_insanos(op, AC, AD);
                    }
                    else if (radioButton4.Checked)
                    {
                        op = 3;
                        Calculos_insanos(op, AC, AD);
                    }
                }
            }
            else
            {
                MessageBox.Show("No valido");
                textBox1.Text = ""; textBox3.Text = ""; textBox2.Text = "";
            }
        }

        public void Calculos_insanos(int OP, int AC, int AD)
        {
            decimal P = Convert.ToDecimal(textBox2.Text);
            decimal rest = P / OP;
            int restanio = AD - AC;
            if (restanio >= OP)
            {
                label8.Text = "Contablemente no vale nada";
            }
            else if (restanio < OP)
            {
                int x = 0; AC += 1;
                Task.Run(() =>
                {

                    while (x < restanio)
                    {
                        label8.Invoke((MethodInvoker)delegate
                        {
                            label8.Text = "Año " + AC + " - " + P.ToString();
                        });

                        P -= rest;

                        AC++;
                        x++;
                        Thread.Sleep(2000);
                    }
                });
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
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
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
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
        private void button3_Click(object sender, EventArgs e)
        {
            ToggleTheme();
        }
    }
}
