using AgendamentoCliente.Models;
using Newtonsoft.Json;
using System.Diagnostics;

namespace AgendamentoCliente.Telas
{
    public partial class AgendamentoPaciente : Form


    {

        public AgendamentoPaciente()
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";


            autocompletes();
        }

        public void autocompletes()
        {

            txbNomePaciente.AutoCompleteMode = AutoCompleteMode.Suggest;
            txbNomePaciente.AutoCompleteSource = AutoCompleteSource.CustomSource;

            adicionaAutoCompletePaciente();
            adicionaAutoCompleteMedico();

            txbNomeMedico.AutoCompleteMode = AutoCompleteMode.Suggest;
            txbNomeMedico.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private async void adicionaAutoCompletePaciente()
        {
            HttpClient http = new HttpClient();
            HttpResponseMessage response = await http.GetAsync("http://localhost:8080/api/v1/paciente");

            string v = await response.Content.ReadAsStringAsync();
            List<Paciente> pacientes = JsonConvert.DeserializeObject<List<Paciente>>(v);

            List<string> nomes = new List<string>();

            pacientes.ForEach(paciente =>
            {
                nomes.Add(paciente.NomeCompleto.ToString());
            });

            txbNomePaciente.AutoCompleteCustomSource.AddRange(nomes.ToArray());
        }

        private async void adicionaAutoCompleteMedico()
        {
            HttpClient http = new HttpClient();
            HttpResponseMessage response = await http.GetAsync("http://localhost:8080/api/v1/medico");

            string v = await response.Content.ReadAsStringAsync();
            List<Medico> medicos = JsonConvert.DeserializeObject<List<Medico>>(v);

            List<string> nomes = new List<string>();

            medicos.ForEach(medico =>
            {
                nomes.Add(medico.NomeCompleto.ToString());
            });

            txbNomeMedico.AutoCompleteCustomSource.AddRange(nomes.ToArray());
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            //Agendamento Utilizando o Banco de Dados
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            Telas.CadastraPaciente cp = new Telas.CadastraPaciente();
            cp.Show();
            Close();
        }

        private void txbNomePaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbNomeMedico_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgendamentoPaciente_Load(object sender, EventArgs e)
        {
        }

        private void AgendamentoPaciente_Load_1(object sender, EventArgs e)
        {
            autocompletes();

        }

        private async void btnAgendar_Click_1(object sender, EventArgs e)
        {

            string nomePaciente = txbNomePaciente.Text;
            string nomeMedico = txbNomeMedico.Text;
            string data = dateTimePicker1.Text;

            Debug.WriteLine(nomePaciente);

            HttpClient http = new HttpClient();


            Dictionary<string, string> formData = new Dictionary<string, string>
        {
                {"nomePaciente", nomePaciente },
                {"nomeMedico", nomeMedico },
                {"dataHora", data }
        };
            var content = new FormUrlEncodedContent(formData);
            try
            {
                HttpResponseMessage response = await http.PostAsync("http://localhost:8080/api/v1/atendimento", content);
                string stringResponse = await response.Content.ReadAsStringAsync();

                Atendimento atendimento = JsonConvert.DeserializeObject<Atendimento>(stringResponse);

                Debug.WriteLine(atendimento.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            Close();
        }

        private void txbNomePaciente_TextChanged_1(object sender, EventArgs e)
        {

        }

    }
}
