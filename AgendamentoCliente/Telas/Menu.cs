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

        private void btnCadastrar_Click_1(object sender, EventArgs e)
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
            atualizaTabelaAgendamento();
        }

        private async void atualizaTabelaAgendamento()
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync("http://localhost:8080/api/v1/atendimento");

            string v = await httpResponseMessage.Content.ReadAsStringAsync();

            List<Atendimento> atendimentoLista = JsonConvert.DeserializeObject<List<Atendimento>>(v);

            atendimentoLista.ForEach(atendimento =>
            {

                DataGridViewRow linha = new DataGridViewRow();

                DataGridViewTextBoxCell nomeMedicoCelula = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell nomePacienteCelula = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell dataCelula = new DataGridViewTextBoxCell();



                nomePacienteCelula.Value = atendimento.Paciente.NomeCompleto;
                nomeMedicoCelula.Value = atendimento.Medico.NomeCompleto;

                string inputString = atendimento.DataAtendimento;

                string formattedDateTime;

                try
                {
                    DateTime dateTime = DateTime.ParseExact(inputString, "yyyy-MM-dd'T'HH:mm:ss", CultureInfo.InvariantCulture);
                    formattedDateTime = dateTime.ToString("dd/MM/yyyy HH:mm");
                }
                catch (Exception e)
                {
                    DateTime dateTime = DateTime.Parse(inputString, CultureInfo.CurrentCulture);
                    DateTime newDateTime = new DateTime(dateTime.Ticks);
                    formattedDateTime = newDateTime.ToString("dd/MM/yyyy HH:mm");
                }

                dataCelula.Value = formattedDateTime;

                linha.Cells.AddRange(nomeMedicoCelula, nomePacienteCelula, dataCelula);

                visualizaPaciente.Rows.Add(linha);

            });
        }

        private void visualizaPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            for (int i = visualizaPaciente.Rows.Count - 2; i >= 0; i--)
            {
                visualizaPaciente.Rows.RemoveAt(i);
            }
            atualizaTabelaAgendamento();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            atualizaTabelaAgendamento();
        }

        private void btnAgendar_Click_1(object sender, EventArgs e)
        {
 Telas.AgendamentoPaciente ap = new Telas.AgendamentoPaciente();
            ap.Show();

        }
    }
}
