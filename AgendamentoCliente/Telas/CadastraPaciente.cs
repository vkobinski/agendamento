using AgendamentoCliente.Models;
using System.Globalization;

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
            MenuSingleton.Instance.Menu.Visible = true;
            this.Close();
        }

        private async Task enviarForm()
        {
            var nome = txbNomePaciente.Text;
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            nome = textInfo.ToTitleCase(nome);
            var dataPaciente = dataNascimento.Value;
            try
            {

                if (nome.Count() == 0) throw new Exception();

                var dataFormulario = dataPaciente.ToString().Split(" ")[0];
                if (dataFormulario.ToString().Equals(DateTime.Today.ToString().Split(" ")[0])) throw new Exception();

                HttpClient httpClient = new HttpClient();

                Dictionary<string, string> formData = new Dictionary<string, string>
        {
            { "nomeCompleto",  nome},
            { "dataNascimento", dataFormulario },
        };
                var content = new FormUrlEncodedContent(formData);


                // Send POST request to API endpoint
                HttpResponseMessage response = await httpClient.PostAsync(Utils.GetIp("/api/v1/paciente/form"), content);

                // Check response status
                if (!response.IsSuccessStatusCode)
                {
                    btnConfirmar.Enabled = true;
                    MessageBox.Show("Não foi possível cadastrar, verifique se há algum campo vazio");
                }
                else
                {
                    MenuSingleton.Instance.Menu.Visible = true;
                    Close();
                }
            }
            catch (Exception ex)
            {
                    btnConfirmar.Enabled = true;
                MessageBox.Show("Não foi possível cadastrar, verifique se há algum campo vazio");
            }
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            btnConfirmar.Enabled = true;
            enviarForm();
        }

        private void CadastraPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {

            MenuSingleton.Instance.MenuVisible();
        }

        private void dataNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            if (e.KeyChar == (char)Keys.Space)
            {
                SendKeys.Send("{RIGHT}");
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
