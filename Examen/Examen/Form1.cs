namespace Examen
{
    public partial class Form1 : Form
    {
        Menu menu = new Menu();
        public Form1()
        {
            InitializeComponent();
        }

        private void iniciarSeccion_Click(object sender, EventArgs e)
        {

            bool verificar = email.Text.Equals("admin") && password.Text.Equals("123") ? true : false;
            if (verificar) { 
                this.Hide();
                menu.ShowDialog();
                this.Show();
            }
        }
    }
}
