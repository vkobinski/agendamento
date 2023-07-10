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

        private void Menu_Activated(object sender, EventArgs e)
        {
            atualizaTabelaAgendamento();
            Visible = true;
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Telas.AgendamentoPaciente ap = new Telas.AgendamentoPaciente();
            ap.Show();
            Visible = false;
        }

        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            Telas.DesmarcaPaciente dp = new Telas.DesmarcaPaciente();
            dp.Show();
            Visible = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Telas.CadastraMedico cm = new Telas.CadastraMedico();
            cm.Show();
            Visible = false;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Telas.RemoveMedico rm = new Telas.RemoveMedico();
            rm.Show();
            Visible = false;
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            Telas.AgendamentoPaciente ap = new Telas.AgendamentoPaciente();
            ap.Show();
            Visible = false;
        }

        private async void Menu_Load(object sender, EventArgs e)
        {
            atualizaTabelaAgendamento();
        }

        private async void atualizaTabelaAgendamento()
        {
            for (int i = visualizaPaciente.Rows.Count - 2; i >= 0; i--)
            {
                visualizaPaciente.Rows.RemoveAt(i);
            }
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
                DataGridViewTextBoxCell idCelula = new DataGridViewTextBoxCell();



                nomePacienteCelula.Value = atendimento.Paciente.NomeCompleto;
                nomeMedicoCelula.Value = atendimento.Medico.NomeCompleto;
                idCelula.Value = atendimento.AtendimentoId;

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

                linha.Cells.AddRange(idCelula, nomeMedicoCelula, nomePacienteCelula, dataCelula);


                visualizaPaciente.Rows.Add(linha);

            });
        }

        private void visualizaPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            atualizaTabelaAgendamento();
        }

        private void btnCadastrarPaciente_Click(object sender, EventArgs e)
        {
            Telas.CadastraPaciente cp = new Telas.CadastraPaciente();
            cp.Show();
            Visible = false;

        }

        private void btnAgendar_Click_1(object sender, EventArgs e)
        {
 Telas.AgendamentoPaciente ap = new Telas.AgendamentoPaciente();
            ap.Show();
            Visible = false;

        }

        private void Menu_Load_1(object sender, EventArgs e)
        {
            atualizaTabelaAgendamento();
            Visible = true;

        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            atualizaTabelaAgendamento();

        }

        private async void desmarcar(String idAtendimento)
        {

            HttpClient httpClient = new HttpClient();

            Dictionary<string, string> formData = new Dictionary<string, string>
        {
            { "idAtendimento",  idAtendimento},
        };
            var content = new FormUrlEncodedContent(formData);
            try
            {
                HttpResponseMessage response = await httpClient.PutAsync("http://localhost:8080/api/v1/atendimento/desmarcar", content);

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


        private void btnDesmarcar_Click_1(object sender, EventArgs e)
        {
            if (visualizaPaciente.SelectedRows.Count < 1 || visualizaPaciente.SelectedRows[0].Cells.Count < 1) return;

            DataGridViewCell selectedCell = visualizaPaciente.SelectedRows[0].Cells[0];

            if (!(selectedCell is DataGridViewTextBoxCell) || selectedCell.Value == null) return;

            String idAtendimento = selectedCell.Value.ToString();

            desmarcar(idAtendimento);

            atualizaTabelaAgendamento();
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
 Telas.AgendamentoPaciente ap = new Telas.AgendamentoPaciente();
            ap.Show();
            Visible = false;


        }

        private void btnRemover_Click_1(object sender, EventArgs e)
        {
 Telas.RemoveMedico rm = new Telas.RemoveMedico();
            rm.Show();
            Visible = false;

        }

        private void btnCadastrarPaciente_Click_1(object sender, EventArgs e)
        {
 Telas.CadastraPaciente cp = new Telas.CadastraPaciente();
            cp.Show();
            Visible = false;

        }
    }

}
