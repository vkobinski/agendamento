using AgendamentoCliente.Models;
using Newtonsoft.Json;

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
            MenuSingleton.Instance.MenuVisible();
            Close();
        }

        public void autocompletes()
        {

            txbNomePaciente.AutoCompleteMode = AutoCompleteMode.Suggest;
            txbNomePaciente.AutoCompleteSource = AutoCompleteSource.CustomSource;

            adicionaAutoCompletePaciente();

        }

        private async void adicionaAutoCompletePaciente()
        {
            try
            {

                HttpClient http = new HttpClient();
                HttpResponseMessage response = await http.GetAsync(Utils.GetIp("/api/v1/paciente"));

                string v = await response.Content.ReadAsStringAsync();
                List<Paciente> pacientes = JsonConvert.DeserializeObject<List<Paciente>>(v);

                List<string> nomes = new List<string>();

                pacientes.ForEach(paciente =>
                {
                    nomes.Add(paciente.NomeCompleto.ToString());
                });

                txbNomePaciente.AutoCompleteCustomSource.AddRange(nomes.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível encontrar registros de pacientes no servidor");
            }
        }




        private void btnDesmarcar_Click(object sender, EventArgs e)
        {

            string nomePaciente = txbNomePaciente.Text;
            string nascimento = dateTimePicker1.Text;
            string dataAtendimento = dateTimePicker2.Text;

            enviarForm(nomePaciente, nascimento, dataAtendimento);
            MenuSingleton.Instance.MenuVisible();
            MenuSingleton.Instance.Menu.atualizaTabelaAgendamento();
            Close();

        }
        private async Task enviarForm(string nomePaciente, string nascimento, string dataAtendimento)
        {
            HttpClient httpClient = new HttpClient();

            Dictionary<string, string> formData = new Dictionary<string, string>
        {
            { "nomePaciente",  nomePaciente},
            { "dataNascimento",  nascimento},
            { "dataAtendimento",  dataAtendimento},
        };
            var content = new FormUrlEncodedContent(formData);
            try
            {
                HttpResponseMessage response = await httpClient.PutAsync(Utils.GetIp("/api/v1/atendimento/desmarcar-buscando"), content);

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Não foi possível desmarcar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível desmarcar, verifique se há algum campo vazio!");
            }

        }


        private void DesmarcaPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuSingleton.Instance.MenuVisible();
            MenuSingleton.Instance.Menu.atualizaTabelaAgendamento();
        }

        private void DesmarcaPaciente_Load(object sender, EventArgs e)
        {
            autocompletes();
        }

        private async void completaNascimentoPaciente()
        {

            HttpClient httpClient = new HttpClient();

            Dictionary<string, string> formData = new Dictionary<string, string>
        {
            { "nome",  txbNomePaciente.Text},
        };
            var content = new FormUrlEncodedContent(formData);

            try
            {

                HttpClient http = new HttpClient();
                HttpResponseMessage response = await http.PostAsync(Utils.GetIp("/api/v1/paciente/busca-nome-completo"), content);

                string v = await response.Content.ReadAsStringAsync();
                Paciente paciente = JsonConvert.DeserializeObject<Paciente>(v);

                dateTimePicker1.Text = paciente.DataNascimento.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível conectar ao servidor");
            }
        }

        private void dateTimePicker1_Enter(object sender, EventArgs e)
        {

            completaNascimentoPaciente();
        }
    }
}
