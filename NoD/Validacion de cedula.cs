using System;
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
    public partial class Validacion_de_cedula : Form
    {
        public Validacion_de_cedula()
        {
            InitializeComponent();
            //Tienes 2 opciones
            //1. Terminar
            //2. Suicidio
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
        private void label5_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string ci = textBox1.Text;
            if (ci.Length < 10 || ci.Length > 10)
            {
                label5.ForeColor = Color.Red;
                label5.Text = "NO";
            }
            if (ci.Length > 3)
            {
                if (ci.Length == 10)
                {
                    /*
                    falsetrue.ForeColor = Color.Green;
                    falsetrue.Text = "SI";
                    */
                    string a2 = ci.Substring(0, 2);
                    char a3 = ci.Substring(2, 1)[0];
                    int X1 = Convert.ToInt32(a2);
                    char c66 = '\u0036';
                    if (X1 > 24)
                    {
                        label5.ForeColor = Color.Red;
                        label5.Text = "NO";
                    }
                    if (a3 > c66)
                    {
                        label5.ForeColor = Color.Red;
                        label5.Text = "NO";
                    }
                    char[] cisp = ci.ToCharArray();

                    //Ubicacion de variable
                    char c1 = (cisp[0]);
                    char c2 = (cisp[1]);
                    char c3 = (cisp[2]);
                    char c4 = (cisp[3]);
                    char c5 = (cisp[4]);
                    char c6 = (cisp[5]);
                    char c7 = (cisp[6]);
                    char c8 = (cisp[7]);
                    char c9 = (cisp[8]);
                    char c10 = (cisp[9]);

                    //Asignación de variable
                    int n1 = int.Parse(c1.ToString());
                    n1 = n1 * 2;
                    int n2 = int.Parse(c2.ToString());
                    int n3 = int.Parse(c3.ToString());
                    n3 = n3 * 2;
                    int n4 = int.Parse(c4.ToString());
                    int n5 = int.Parse(c5.ToString());
                    n5 = n5 * 2;
                    int n6 = int.Parse(c6.ToString());
                    int n7 = int.Parse(c7.ToString());
                    n7 = n7 * 2;
                    int n8 = int.Parse(c8.ToString());
                    int n9 = int.Parse(c9.ToString());
                    int n10 = int.Parse(c10.ToString());
                    n9 = n9 * 2;

                    if (n1 >= 10)
                    {
                        n1 = n1 - 9;
                    }
                    if (n3 >= 10)
                    {
                        n3 = n3 - 9;
                    }
                    if (n5 >= 10)
                    {
                        n5 = n5 - 9;
                    }
                    if (n7 >= 10)
                    {
                        n7 = n7 - 9;
                    }
                    if (n9 >= 10)
                    {
                        n9 = n9 - 9;
                    }
                    int uwu = 0; int nt = 0;
                    int[] array_suma =
                    {
                    n1, n2, n3, n4, n5, n6, n7, n8, n9
                    };

                    while (uwu < array_suma.Length)
                    {
                        nt += array_suma[uwu];
                        uwu++;
                    }

                    //Esto redondea un número hacia arriba uwu
                    int op = (int)Math.Ceiling((double)nt / 10) * 10;
                    int qw = op - nt;

                    if (qw == n10)
                    {

                        label5.ForeColor = Color.Green;
                        label5.Text = "SI";
                        string[] provinces = { "Azuay", "Bolivar", "Cañar", "Carchi", "Cotopaxi", "Chimborazo", "El Oro", "Esmeraldas", "Guayas", "Imbabura", "Loja", "Los Ríos", "Manabí", "Morona Santiago", "Napo", "Pastaza", "Pichincha", "Tungurahua", "Zamora Chinchipe", "Galápagos", "Sucumbíos", "Orellana", "Santo Domingo de los Tsáchilas" };

                        if (X1 >= 1 && X1 <= provinces.Length) // Reemplazo todos los if por un solo arreglo de strings y su índice
                        {
                            label7.Text = (provinces[X1 - 1]);
                        }

                        else if (X1 == 30)
                        {
                            label7.Text = ("Exterior");
                        }
                        else
                        {
                            label7.Text = "--";
                        }
                    }
                    if (qw != n10)
                    {
                        label7.Text = "--";
                    }


                }
            }
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
        private bool isDarkTheme = false;
        private void button2_Click(object sender, EventArgs e)
        {
            ToggleTheme();
        }
    }
}
