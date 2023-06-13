using AgendamentoCliente.Models;
using Newtonsoft.Json;

namespace AgendamentoCliente.Telas
{
    public partial class RemoveMedico : Form
    {
        public RemoveMedico()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //Remover Médico
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {

            HttpClient httpClient = new HttpClient();

            Dictionary<string, string> formData = new Dictionary<string, string>
        {
                {"nome", txbNomeMedico.Text }
        };

            var content = new FormUrlEncodedContent(formData);
            try
            {
                HttpResponseMessage response = await httpClient.PostAsync("http://localhost:8080/api/v1/medico/procura", content);
                string stringResponse = await response.Content.ReadAsStringAsync();

                Medico medico = JsonConvert.DeserializeObject<Medico>(stringResponse);

                if(medico == null)
                {
                    throw new HttpRequestException("Médico não encontrado");
                }

                DataGridViewRow linha = new DataGridViewRow();

                DataGridViewTextBoxCell nomeCelula = new();
                DataGridViewTextBoxCell idCelula = new();

                nomeCelula.Value = medico.NomeCompleto;
                idCelula.Value = medico.MedicoId;

                linha.Cells.AddRange(nomeCelula, idCelula);

                visualizaMedico.Rows.Add(linha);


            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }


        }

        private async void btnRemover_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow v = visualizaMedico.Rows[0];
            long idMedico = (long)v.Cells[1].Value;
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage httpResponseMessage = await httpClient.DeleteAsync("http://localhost:8080/api/v1/medico/" + idMedico);

            if (httpResponseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                medicoExcluido.Visible = true;
            }

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void RemoveMedico_Load(object sender, EventArgs e)
        {

        }
    }
}
