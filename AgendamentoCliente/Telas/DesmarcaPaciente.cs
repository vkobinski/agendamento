namespace AgendamentoCliente.Telas
{
    public partial class DesmarcaPaciente : Form
    {
        public DesmarcaPaciente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
            Telas.Menu m = new Telas.Menu();
            m.Show();
        }

        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            //Desmarcar um Paciente Agendado
            Close();
            Telas.Menu m = new Telas.Menu();
            m.Show();
        }

        private void txbNomePaciente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
