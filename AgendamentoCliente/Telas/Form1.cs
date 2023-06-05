namespace AgendamentoCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txbUser.Text == "admin" && txbPassword.Text == "1234")
            {
                Telas.Menu menu = new Telas.Menu();
                menu.Show();
                this.Visible = false;
            }
            else if (txbUser.Text == "" || txbPassword.Text == "")
            {
                Telas.Erro erro = new Telas.Erro();
                erro.Show();
            }
            else
            {
                Telas.Erro erro = new Telas.Erro();
                erro.Show();
            }
        }
    }
}