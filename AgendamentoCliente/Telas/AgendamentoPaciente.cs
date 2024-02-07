using AgendamentoCliente.Models;
using Newtonsoft.Json;
using System.Net;

namespace AgendamentoCliente.Telas
{
    public partial class AgendamentoPaciente : Form


    {
        private ListBox customListBoxPaciente;
        private ListBox customListBoxMedico;

        public AgendamentoPaciente()
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";


            autocompletes();

            //if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        }

        public void autocompletes()
        {

            txbNomePaciente.AutoCompleteMode = AutoCompleteMode.Suggest;
            txbNomePaciente.AutoCompleteSource = AutoCompleteSource.CustomSource;

            adicionaAutoCompletePaciente();
            adicionaAutoCompleteMedico();

            txbNomeMedico.AutoCompleteMode = AutoCompleteMode.Suggest;
            txbNomeMedico.AutoCompleteSource = AutoCompleteSource.CustomSource;

            listBoxPaciente();
            listBoxMedico();
        }

        private void listBoxPaciente()
        {
            // Configuração do ListBox Paciente
            customListBoxPaciente = new ListBox();
            customListBoxPaciente.Font = new Font("Calibri", 16); // Altere a fonte e o tamanho conforme desejado
            customListBoxPaciente.Visible = false;
            customListBoxPaciente.Width = txbNomePaciente.Width;
            this.Controls.Add(customListBoxPaciente);

            customListBoxPaciente.Click += CustomListBoxPaciente_Click;
            customListBoxPaciente.LostFocus += CustomListBoxPaciente_LostFocus;
        }

        private void listBoxMedico()
        {
            // Configuração do ListBox Medico
            customListBoxMedico = new ListBox();
            customListBoxMedico.Font = new Font("Calibri", 16); // Altere a fonte e o tamanho conforme desejado
            customListBoxMedico.Visible = false;
            customListBoxMedico.Width = txbNomePaciente.Width;
            this.Controls.Add(customListBoxMedico);

            customListBoxMedico.Click += CustomListBoxMedico_Click;
            customListBoxMedico.LostFocus += CustomListBoxMedico_LostFocus;
        }

        private void CustomListBoxPaciente_LostFocus(object sender, EventArgs e)
        {
            customListBoxPaciente.Visible = false;
        }

        private void CustomListBoxPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Down)
            {
                customListBoxPaciente.SelectedIndex += 1;
            }
        }


        private void CustomListBoxPaciente_Click(object sender, EventArgs e)
        {
            if (customListBoxPaciente.SelectedItem != null)
            {
                string input = customListBoxPaciente.SelectedItem.ToString();
                try
                {
                    string[] splitInput = input.Split(new string[] { "          " }, StringSplitOptions.None);
                    string name = splitInput[0];
                    string dateString = splitInput[1];

                    txbNomePaciente.Text = name;
                    txbNascimento.Text = dateString;
                    customListBoxPaciente.Visible = false;
                }
                catch
                {
                    return;
                }
                this.BeginInvoke(new MethodInvoker(() => { txbNomeMedico.Focus(); }));

            }
        }

        private void CustomListBoxMedico_LostFocus(object sender, EventArgs e)
        {
            customListBoxMedico.Visible = false;
        }

        private void CustomListBoxMedico_Click(object sender, EventArgs e)
        {
            if (customListBoxMedico.SelectedItem != null)
            {
                string input = customListBoxMedico.SelectedItem.ToString();

                txbNomeMedico.Text = input;

                this.BeginInvoke(new MethodInvoker(() => { dateTimePicker1.Focus(); }));
                dateTimePicker1.Focus();
            }
        }


        private async Task<string[]> adicionaAutoCompletePaciente()
        {
            try
            {

                HttpClient http = new HttpClient();
                HttpResponseMessage response = await http.GetAsync(Utils.GetIp("/api/v1/paciente/ativo"));

                string v = await response.Content.ReadAsStringAsync();
                List<Paciente> pacientes = JsonConvert.DeserializeObject<List<Paciente>>(v);

                List<string> nomes = new List<string>();

                pacientes.ForEach(paciente =>
                {
                    if (paciente.ativo) nomes.Add(paciente.NomeCompleto.ToString() + "          " + paciente.DataNascimento.ToString());
                });

                return nomes.ToArray();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível agendar, verifique se há algum campo vazio");
            }
            return null;
        }

        private async Task<string[]> adicionaAutoCompleteMedico()
        {
            try
            {

                HttpClient http = new HttpClient();
                HttpResponseMessage response = await http.GetAsync(Utils.GetIp("/api/v1/medico"));

                string v = await response.Content.ReadAsStringAsync();
                List<Medico> medicos = JsonConvert.DeserializeObject<List<Medico>>(v);

                List<string> nomes = new List<string>();

                medicos.ForEach(medico =>
                {
                    if (medico.Ativo) nomes.Add(medico.NomeCompleto.ToString());
                });

                return nomes.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível encontrar registros de médicos no servidor");
            }
            return null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuSingleton.Instance.Menu.Visible = true;
            Close();
        }


        private void AgendamentoPaciente_Load_1(object sender, EventArgs e)
        {
            autocompletes();

        }

        private async void btnAgendar_Click(object sender, EventArgs e)
        {

            btnAgendar.Enabled = false;

            string nomePaciente = txbNomePaciente.Text;

            string dataNascimento = txbNascimento.Text;

            string nomeMedico = txbNomeMedico.Text;
            string data = dateTimePicker1.Text;

            try
            {

                if (nomePaciente.Count() == 0)
                {
                    throw new Exception();
                }

                HttpClient http = new HttpClient();


                Dictionary<string, string> formData = new Dictionary<string, string>
        {
                {"nomePaciente", nomePaciente.Trim() },
                {"dataNascimento", dataNascimento },
                {"nomeMedico", nomeMedico },
                {"dataHora", data }
        };
                var content = new FormUrlEncodedContent(formData);


                HttpResponseMessage response = await http.PostAsync(Utils.GetIp("/api/v1/atendimento"), content);
                string stringResponse = await response.Content.ReadAsStringAsync();

                if (response.StatusCode.Equals(HttpStatusCode.BadRequest))
                {
                    if (stringResponse.Contains("Pacientes Duplicados"))
                    {
                        btnAgendar.Enabled = true;
                        MessageBox.Show("Não foi possível agendar, há pacientes duplicados!");
                        return;
                    }
                    if (stringResponse.Contains("ocupado"))
                    {

                        btnAgendar.Enabled = true;
                        MessageBox.Show("Esse horário para o profissional está marcado como ocupado!");
                        return;
                    }
                }

                Atendimento atendimento = JsonConvert.DeserializeObject<Atendimento>(stringResponse);

                if (response.IsSuccessStatusCode)
                {
                    MenuSingleton.Instance.MenuVisible();
                    Close();
                }
                else
                {
                    btnAgendar.Enabled = true;
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                btnAgendar.Enabled = true;
                MessageBox.Show("Não foi possível agendar, verifique se há algum campo vazio");
            }
        }

        private void AgendamentoPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuSingleton.Instance.MenuVisible();
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            if (e.KeyChar == (char)Keys.Space)
            {
                SendKeys.Send("{RIGHT}");
                e.Handled = true;
            }

        }

        private async void txbNomePaciente_KeyPress(object sender, KeyPressEventArgs e)
        {


            string[] suggestions = await adicionaAutoCompletePaciente();
            string filter = txbNomePaciente.Text.ToLower();
            string[] filteredSuggestions = Array.FindAll(suggestions, s => s.ToLower().Contains(filter));

            customListBoxPaciente.Items.Clear();
            customListBoxPaciente.Items.AddRange(filteredSuggestions);
            customListBoxPaciente.BringToFront();

            customListBoxPaciente.Visible = filteredSuggestions.Length > 0;
            customListBoxPaciente.Top = txbNomePaciente.Bottom;
            customListBoxPaciente.Left = txbNomePaciente.Left;


        }

        private async void txbNomeMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            string[] suggestions = await adicionaAutoCompleteMedico();
            string filter = txbNomeMedico.Text.ToLower();
            string[] filteredSuggestions = Array.FindAll(suggestions, s => s.ToLower().Contains(filter));

            customListBoxMedico.Items.Clear();
            customListBoxMedico.Items.AddRange(filteredSuggestions);
            customListBoxMedico.BringToFront();

            customListBoxMedico.Visible = filteredSuggestions.Length > 0;
            customListBoxMedico.Top = txbNomeMedico.Bottom;
            customListBoxMedico.Left = txbNomeMedico.Left;

        }

        private void txbNomePaciente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                customListBoxPaciente.SelectedIndex += 1;
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (customListBoxPaciente.SelectedItem != null)
                {
                    string input = customListBoxPaciente.SelectedItem.ToString();
                    try
                    {
                        string[] splitInput = input.Split(new string[] { "          " }, StringSplitOptions.None);
                        string name = splitInput[0];
                        string dateString = splitInput[1];

                        txbNomePaciente.Text = name;
                        txbNascimento.Text = dateString;
                        customListBoxPaciente.Visible = false;
                    }
                    catch
                    {
                        return;
                    }
                    this.BeginInvoke(new MethodInvoker(() => { txbNomeMedico.Focus(); }));


                }

            }
        }

        private void txbNomeMedico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                customListBoxMedico.SelectedIndex += 1;
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (customListBoxMedico.SelectedItem != null)
                {
                    string input = customListBoxMedico.SelectedItem.ToString();
                    txbNomeMedico.Text = input;
                    customListBoxMedico.Visible = false;
                    this.BeginInvoke(new MethodInvoker(() => { dateTimePicker1.Focus(); }));
                    dateTimePicker1.Focus();
                }
            }
        }

    }
}
