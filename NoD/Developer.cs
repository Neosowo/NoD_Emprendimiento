using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoD
{
    public partial class Developer : Form
    {
        public Developer()
        {
            InitializeComponent();
            Theme.ApplyDarkTheme(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }


        private void Developer_Load(object sender, EventArgs e)
        {

        }
        private void VisitLink(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el enlace: " + ex.Message + ". Asegúrate de que tu navegador predeterminado esté configurado correctamente y de que no haya ningún problema de seguridad en tu máquina.");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitLink("https://github.com/Neosowo");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitLink("https://discordapp.com/users/715274827203870852");
        }
    }
}
