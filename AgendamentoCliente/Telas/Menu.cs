using AgendamentoCliente.Models;
using Newtonsoft.Json;
using System.Globalization;

namespace AgendamentoCliente.Telas
{
    public partial class Menu : Form
    {
        private Form1 form1;
        public Menu(Form1 form1)
        {
            InitializeComponent();
            MenuSingleton.createInstance(this);
            this.form1 = form1;
        }

        private async void Menu_Load(object sender, EventArgs e)
        {
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

            adicionaAutoCompleteMedico();
        }

        public async Task atualizaTabelaAgendamento()
        {
            int count = visualizaPaciente.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                visualizaPaciente.Rows.RemoveAt(0);
            }
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage httpResponseMessage = null;

            try
            {
                httpResponseMessage = await httpClient.GetAsync(Utils.GetIp("/api/v1/atendimento/today-and-forth"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Não foi possível conectar ao servidor!");
                return;
            }

            try
            {


                string v = await httpResponseMessage.Content.ReadAsStringAsync();

                List<Atendimento> atendimentoLista = JsonConvert.DeserializeObject<List<Atendimento>>(v);

                atendimentoLista.RemoveAll(at => { return !at.Ativo; });

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

                    linha.Cells.AddRange(idCelula, nomePacienteCelula, nomeMedicoCelula, dataCelula);


                    visualizaPaciente.Rows.Add(linha);

                });


            }
            catch (Exception e)
            {

            };
        }

        public async void atualizaTabelaAgendamentoForMedico(String nomeMedico)
        {

            try
            {
                int count = visualizaPaciente.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    visualizaPaciente.Rows.RemoveAt(0);
                }
                HttpResponseMessage httpResponseMessage = null;

                HttpClient httpClient = new HttpClient();

                Dictionary<string, string> formData = new Dictionary<string, string>
        {
            { "nome",  nomeMedico},
        };
                var content = new FormUrlEncodedContent(formData);


                httpResponseMessage = await httpClient.PostAsync(Utils.GetIp("/api/v1/atendimento/search"), content);
                string v = await httpResponseMessage.Content.ReadAsStringAsync();

                List<Atendimento> atendimentoLista = JsonConvert.DeserializeObject<List<Atendimento>>(v);

                //int quantity = atendimentoLista.RemoveAll((atendimento) =>
                //{
                //    DateTime hoje = DateTime.Now;
                //    DateTime diaAtendimento = DateTime.Parse(atendimento.DataAtendimento.Split(" ")[0]);

                //    if (diaAtendimento >= hoje) return false;
                //    return true;
                //});

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

                    linha.Cells.AddRange(idCelula, nomePacienteCelula, nomeMedicoCelula, dataCelula);


                    visualizaPaciente.Rows.Add(linha);

                });

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível encontrar médico na base de dados!");
                return;
            }

        }


        private void btnAgendar_Click_1(object sender, EventArgs e)
        {
            Telas.AgendamentoPaciente ap = new Telas.AgendamentoPaciente();
            ap.Show();
            this.Visible = false;

        }
        public class Response
        {
            public List<Medico> Medicos { get; set; }
            public List<Paciente> Pacientes { get; set; }
        }

        private async void adicionaAutoCompleteMedico()
        {
            try
            {

                HttpClient http = new HttpClient();
                HttpResponseMessage response = await http.GetAsync(Utils.GetIp("/api/v1/search"));

                string v = await response.Content.ReadAsStringAsync();

                Response resposta = JsonConvert.DeserializeObject<Response>(v);

                List<string> nomes = new List<string>();

                resposta.Medicos.ForEach(medico =>
                {
                    if (medico.Ativo) nomes.Add(medico.NomeCompleto.ToString());
                });

                resposta.Pacientes.ForEach(paciente =>
                {
                    nomes.Add(paciente.NomeCompleto.ToString());
                });

                textBox1.AutoCompleteCustomSource.AddRange(nomes.ToArray());
            }
            catch (Exception ex)
            {
                //TODO: implementar caso não haja médicos no servidor
            }

        }


        private async void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            await atualizaTabelaAgendamento();
        }

        private async Task desmarcar(String idAtendimento)
        {

            HttpClient httpClient = new HttpClient();

            Dictionary<string, string> formData = new Dictionary<string, string>
        {
            { "idAtendimento",  idAtendimento},
        };
            var content = new FormUrlEncodedContent(formData);
            try
            {
                HttpResponseMessage response = await httpClient.PutAsync(Utils.GetIp("/api/v1/atendimento/desmarcar"), content);

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
        private async void btnDesmarcar_Click_1(object sender, EventArgs e)
        {
            if (visualizaPaciente.SelectedRows.Count < 1 || visualizaPaciente.SelectedRows[0].Cells.Count < 1) return;

            DataGridViewCell selectedCell = visualizaPaciente.SelectedRows[0].Cells[0];
            if (!(selectedCell is DataGridViewTextBoxCell) || selectedCell.Value == null) return;
            String idAtendimento = selectedCell.Value.ToString();
            DialogResult confirm = MessageBox.Show("Deseja desmarcar o agendamento?", "Confirmar", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                await desmarcar(idAtendimento);
                await atualizaTabelaAgendamento();
            }

            //new Telas.DesmarcaPaciente().Show();
            //MenuSingleton.Instance.MenuVisible();
            //this.Visible = false;
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            Telas.CadastraMedico cm = new Telas.CadastraMedico();
            cm.Show();
            this.Visible = false;

        }

        private void btnCadastrarPaciente_Click_1(object sender, EventArgs e)
        {
            Telas.CadastraPaciente cp = new Telas.CadastraPaciente();
            cp.Show();
            this.Visible = false;
        }

        private void btnListaMedico_Click(object sender, EventArgs e)
        {
            new ListaMedico().Show();
            this.Visible = false;
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.form1.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nomeMedico = textBox1.Text;
            if (nomeMedico.Count() <= 0)
            {
                atualizaTabelaAgendamento();
                return;
            }
            atualizaTabelaAgendamentoForMedico(nomeMedico);
        }

        private async void Menu_Activated(object sender, EventArgs e)
        {
            textBox1.Text = "";
            await atualizaTabelaAgendamento();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnListaPaciente_Click(object sender, EventArgs e)
        {
            new ListaPaciente().Show();
            this.Visible = false;
        }
    }

}
