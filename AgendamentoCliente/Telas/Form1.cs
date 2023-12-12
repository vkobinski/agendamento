namespace AgendamentoCliente
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void entrar()
        {
            if (txbUser.Text == "admin" && txbPassword.Text == "1234")
            {
                Telas.Menu menu = new Telas.Menu(this);
                menu.Show();
                this.Visible = false;
            }
            else if (txbUser.Text == "" || txbPassword.Text == "")
            {
                txbErro.Visible = true;
            }
            else
            {
                txbErro.Visible = true;
            }

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            entrar();
        }

        private void txbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                entrar();
            }
        }
    }
}