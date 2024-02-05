using AgendamentoCliente.Models;
using Newtonsoft.Json;

namespace AgendamentoCliente.Telas
{
    public partial class ListaPaciente : Form
    {

        List<Paciente> pacientes;
        public ListaPaciente()
        {
            InitializeComponent();
            atualizaTabela();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MenuSingleton.Instance.MenuVisible();
            Close();
        }

        private async void atualizaTabela()
        {
            int count = visualizaPaciente.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                visualizaPaciente.Rows.RemoveAt(0);
            }

            HttpClient httpClient = new HttpClient();
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(Utils.GetIp("/api/v1/paciente"));
                string stringResponse = await response.Content.ReadAsStringAsync();

                pacientes = JsonConvert.DeserializeObject<List<Paciente>>(stringResponse);

                pacientes.ForEach((p) =>
                {
                    DataGridViewRow linha = new DataGridViewRow();

                    DataGridViewTextBoxCell idCelula = new();
                    DataGridViewTextBoxCell nomeCelula = new();
                    DataGridViewTextBoxCell dataNascimentoCelula = new();
                    DataGridViewTextBoxCell ativoCelula = new();

                    idCelula.Value = p.PacienteId;
                    nomeCelula.Value = p.NomeCompleto;
                    dataNascimentoCelula.Value = p.DataNascimento.ToString("dd/MM/yyyy");
                    ativoCelula.Value = p.ativo == true ? "Ativo" : "Inativo";

                    linha.Cells.AddRange(idCelula, nomeCelula, dataNascimentoCelula, ativoCelula);

                    visualizaPaciente.Rows.Add(linha);

                });

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível baixar os pacientes");
            }

        }

        private async void desmarcar(String idPaciente)
        {

            HttpClient httpClient = new HttpClient();

            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(Utils.GetIp("/api/v1/paciente/status/" + idPaciente));

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Não foi possível mudar o status do paciente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível mudar o status do paciente");
            }

            atualizaTabela();
        }

        private void btnEditarPaciente_Click(object sender, EventArgs e)
        {

            if (visualizaPaciente.SelectedRows.Count < 1 || visualizaPaciente.SelectedRows[0].Cells.Count < 1) return;

            DataGridViewCell selectedCell = visualizaPaciente.SelectedRows[0].Cells[0];

            if (!(selectedCell is DataGridViewTextBoxCell) || selectedCell.Value == null) return;

            Paciente p = null;
            String idPaciente = selectedCell.Value.ToString();

            pacientes.ForEach((paciente) =>
            {
                if (paciente.PacienteId == Convert.ToInt64(idPaciente))
                {
                    p = paciente;
                }
            });

            Telas.EditaPaciente ep = new Telas.EditaPaciente(Convert.ToInt64(idPaciente), p);
            ep.Show();
            this.Visible = false;
        }

        private void btnRemoverPaciente_Click(object sender, EventArgs e)
        {
            if (visualizaPaciente.SelectedRows.Count < 1 || visualizaPaciente.SelectedRows[0].Cells.Count < 1) return;

            DataGridViewCell selectedCell = visualizaPaciente.SelectedRows[0].Cells[0];

            if (!(selectedCell is DataGridViewTextBoxCell) || selectedCell.Value == null) return;

            DialogResult confirm = MessageBox.Show("Deseja mudar o status do paciente?", "Confirmar", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                String idPaciente = selectedCell.Value.ToString();
                desmarcar(idPaciente);
            }


        }
    }
}
