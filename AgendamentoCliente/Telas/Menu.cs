using AgendamentoCliente.Models;
using Newtonsoft.Json;
using System.Globalization;

namespace AgendamentoCliente.Telas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Telas.AgendamentoPaciente ap = new Telas.AgendamentoPaciente();
            ap.Show();
        }

        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            Telas.DesmarcaPaciente dp = new Telas.DesmarcaPaciente();
            dp.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Telas.CadastraMedico cm = new Telas.CadastraMedico();
            cm.Show();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Telas.RemoveMedico rm = new Telas.RemoveMedico();
            rm.Show();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            Telas.AgendamentoPaciente ap = new Telas.AgendamentoPaciente();
            ap.Show();

        }

        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            Telas.RemoveMedico rm = new Telas.RemoveMedico();
            rm.Show();
        }

        private async void Menu_Load_1(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync("http://localhost:8080/api/v1/atendimento");

            string v = await httpResponseMessage.Content.ReadAsStringAsync();

            List<Atendimento> atendimentoLista = JsonConvert.DeserializeObject<List<Atendimento>>(v);

            DataGridViewRow linha = new DataGridViewRow();
            atendimentoLista.ForEach(atendimento =>
            {


                DataGridViewTextBoxCell nomeCelula = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell idCelula = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell dataCelula = new DataGridViewTextBoxCell();



                idCelula.Value = atendimento.Paciente.NomeCompleto;
                nomeCelula.Value = atendimento.Paciente.PacienteId;

                string inputString = atendimento.DataAtendimento;
                DateTime dateTime = DateTime.ParseExact(inputString, "yyyy-MM-dd'T'HH:mm:ss.ffffff", CultureInfo.InvariantCulture);
                string formattedDateTime = dateTime.ToString("dd/MM/yyyy HH:mm");

                dataCelula.Value = formattedDateTime;

                linha.Cells.AddRange(nomeCelula, idCelula, dataCelula);

                visualizaPaciente.Rows.Add(linha);

            });

        }

        private void visualizaPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
