namespace AgendamentoCliente.Telas
{
    public partial class CadastraPaciente : Form
    {
        public CadastraPaciente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
            Telas.Menu m = new Telas.Menu();
            m.Show();
        }

        private async Task enviarForm()
        {
            var nome = txbNomePaciente.Text;
            var dataPaciente = dataNascimento.Value;
            var dataFormulario = dataPaciente.ToString().Split(" ")[0];

            HttpClient httpClient = new HttpClient();

            Dictionary<string, string> formData = new Dictionary<string, string>
        {
            { "nomeCompleto",  nome},
            { "dataNascimento", dataFormulario },
        };
            var content = new FormUrlEncodedContent(formData);
            try
            {
                // Send POST request to API endpoint
                HttpResponseMessage response = await httpClient.PostAsync("http://localhost:8080/api/v1/paciente/form", content);

                // Check response status
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Form data sent successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to send form data. Response status: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            enviarForm();
            Close();
            Telas.Menu m = new Telas.Menu();
            m.Show();
        }

        private void dataNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txbNomePaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastraPaciente_Load(object sender, EventArgs e)
        {

        }
    }
}
