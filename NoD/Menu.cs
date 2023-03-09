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
    public partial class Menu : Form
    {

        public Menu()
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
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Log = new Form1();
            Log.Show();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Operaciones_matematicas OM = new Operaciones_matematicas();
            Validacion_de_cedula VC = new Validacion_de_cedula();
            Punto_de_equilibrio PE = new Punto_de_equilibrio();
            Ganancia_neta GN = new Ganancia_neta();
            Depreciacion D = new Depreciacion();
            Estadisticas_descriptivas ED = new Estadisticas_descriptivas();
            Facturacion F = new Facturacion();
            Developer Dev = new Developer();

            if (radioButton1.Checked == true)
            {
                this.Hide();
                OM.Show();
            }
            else if (radioButton2.Checked == true)
            {
                this.Hide();
                VC.Show();
            }
            else if (radioButton3.Checked == true)
            {
                this.Hide();
                PE.Show();
            }
            else if (radioButton4.Checked == true)
            {
                this.Hide();
                GN.Show();
            }
            else if (radioButton5.Checked == true)
            {
                this.Hide();
                D.Show();
            }
            else if (radioButton6.Checked == true)
            {
                this.Hide();
                ED.Show();
            }
            else if (radioButton7.Checked == true)
            {
                this.Hide();
                F.Show();
            }
            else if (radioButton8.Checked == true)
            {
                this.Hide();
                Dev.Show();
            }
        }
        private void OM_CheckedChanged(object sender, EventArgs e)
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
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ToggleTheme();
        }
    }
}
