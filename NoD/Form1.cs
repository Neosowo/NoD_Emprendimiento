namespace NoD
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            if (UserBOX.Text == "neo" && PassBOX.Text == "123")
            {
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
            else if (UserBOX.Text == "qwert" && PassBOX.Text == "123")
            {
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
            else if (UserBOX.Text == "123" && PassBOX.Text == "123")
            {
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
            else if (UserBOX.Text == "q" && PassBOX.Text == "so")
            {
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                UserBOX.Text = "";
                PassBOX.Text = "";
                MessageBox.Show("Su usuario u contraseña es incorrecto!");
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
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
        private void button1_Click(object sender, EventArgs e)
        {
            ToggleTheme();
        }
    }
}