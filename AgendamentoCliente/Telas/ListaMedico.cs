using AgendamentoCliente.Models;
using Newtonsoft.Json;

namespace AgendamentoCliente.Telas
{
    public partial class ListaMedico : Form
    {

        List<Usuario> listaMedico;
        public ListaMedico()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MenuSingleton.Instance.MenuVisible();
            Close();
        }

        private void ListaMedico_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuSingleton.Instance.MenuVisible();
        }

        private async void ListaMedico_Load(object sender, EventArgs e)
        {
            atualizaTabela();
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
                HttpResponseMessage response = await httpClient.GetAsync(Utils.GetIp("/api/v1/usuario/list-user"));
                string stringResponse = await response.Content.ReadAsStringAsync();

                List<Usuario> usuarios = JsonConvert.DeserializeObject<List<Usuario>>(stringResponse);
                listaMedico = usuarios;

                usuarios.ForEach((usuario) =>
                {
                    DataGridViewRow linha = new DataGridViewRow();

                    DataGridViewTextBoxCell idCelula = new();
                    DataGridViewTextBoxCell nomeCelula = new();
                    DataGridViewTextBoxCell emailCelula = new();
                    DataGridViewTextBoxCell senhaCelula = new();
                    DataGridViewTextBoxCell ativoCelula = new();

                    idCelula.Value = usuario.medico.MedicoId;
                    nomeCelula.Value = usuario.medico.NomeCompleto;
                    emailCelula.Value = usuario.email;
                    senhaCelula.Value = usuario.password;
                    ativoCelula.Value = usuario.medico.Ativo == true ? "Ativo" : "Inativo";

                    linha.Cells.AddRange(idCelula, nomeCelula, emailCelula, senhaCelula, ativoCelula);

                    visualizaPaciente.Rows.Add(linha);

                });

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível mudar o status do médico");
            }

        }
        private async void desmarcar(String idMedico)
        {

            HttpClient httpClient = new HttpClient();

            try
            {
                HttpResponseMessage response = await httpClient.DeleteAsync(Utils.GetIp("/api/v1/medico/" + idMedico));

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Não foi possível mudar o status do médico");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível mudar o status do médico");
            }

            atualizaTabela();
        }


        private void btnDesmarcar_Click_1(object sender, EventArgs e)
        {
            if (visualizaPaciente.SelectedRows.Count < 1 || visualizaPaciente.SelectedRows[0].Cells.Count < 1) return;

            DataGridViewCell selectedCell = visualizaPaciente.SelectedRows[0].Cells[0];

            if (!(selectedCell is DataGridViewTextBoxCell) || selectedCell.Value == null) return;

            String idAtendimento = selectedCell.Value.ToString();

            desmarcar(idAtendimento);

        }

        private void editar(String id, Usuario u)
        {
            Telas.EditaMedico cm = new Telas.EditaMedico(long.Parse(id), u);
            cm.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (visualizaPaciente.SelectedRows.Count < 1 || visualizaPaciente.SelectedRows[0].Cells.Count < 1) return;

            DataGridViewCell selectedCell = visualizaPaciente.SelectedRows[0].Cells[0];

            if (!(selectedCell is DataGridViewTextBoxCell) || selectedCell.Value == null) return;

            Usuario u = null;
            String idAtendimento = selectedCell.Value.ToString();

            listaMedico.ForEach((medico) =>
            {
                if (medico.idUsuario == Convert.ToInt64(idAtendimento))
                {
                    u = medico;
                }
            });

            editar(idAtendimento, u);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (visualizaPaciente.SelectedRows.Count < 1 || visualizaPaciente.SelectedRows[0].Cells.Count < 1) return;

            DataGridViewCell selectedCell = visualizaPaciente.SelectedRows[0].Cells[0];

            if (!(selectedCell is DataGridViewTextBoxCell) || selectedCell.Value == null) return;

            String idAtendimento = selectedCell.Value.ToString();

            new Calendario(Convert.ToInt64(idAtendimento)).Show();
            this.Visible = false;

        }
    }
}
