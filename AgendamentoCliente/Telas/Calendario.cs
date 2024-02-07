using AgendamentoCliente.Models;
using Newtonsoft.Json;

namespace AgendamentoCliente.Telas
{
    public partial class Calendario : Form
    {

        private long medicoId;

        public Calendario(long medicoId)
        {
            InitializeComponent();
            this.medicoId = medicoId;
        }

        private async void Calendario_Load(object sender, EventArgs e)
        {
            try
            {
                HttpClient http = new HttpClient();


                Dictionary<string, string> formData = new Dictionary<string, string>
        {
                {"week", "0" }
        };
                var content = new FormUrlEncodedContent(formData);


                HttpResponseMessage response = await http.PostAsync(Utils.GetIp("/api/v1/disponibilidade/week/" + medicoId), content);
                string stringResponse = await response.Content.ReadAsStringAsync();

                List<Disponibilidade> disList = JsonConvert.DeserializeObject<List<Disponibilidade>>(stringResponse);

                if (response.IsSuccessStatusCode)
                {

                    int startTime = 7 * 60;
                    int endTime = 21 * 60;
                    int interval = 30;

                    List<string> newHours = new List<string>();

                    for (int minutes = startTime; minutes < endTime; minutes += interval)
                    {
                        int hour = minutes / 60;
                        int minute = minutes % 60;
                        newHours.Add($"{hour.ToString().PadLeft(2, '0')}:{minute.ToString().PadLeft(2, '0')}");
                    }

                    for (int i = 0; i < 28; i++)
                    {
                        DataGridViewRow linha = new DataGridViewRow();

                        List<DataGridViewTextBoxCell> list = new List<DataGridViewTextBoxCell>();
                        for (int j = 0; j < 7; j++)
                        {
                            DataGridViewTextBoxCell cell = new();
                            cell.Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#DDFCCE");
                            cell.Style.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0095FF");


                            cell.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);

                            cell.Value = newHours[i];

                            list.Add(cell);
                        }


                        linha.Cells.AddRange(list.ToArray());
                        grid.Rows.Add(linha);
                    }

                    int column = 0;
                    List<DateOnly> days = new List<DateOnly>();
                    days.Add(disList[0].Dia);

                    for (int x = 0; x < disList.Count; x++)
                    {

                        Disponibilidade dis = disList[x];

                        if (days[column].CompareTo(dis.Dia) != 0)
                        {
                            days.Add(dis.Dia);
                            column++;
                        }

                        if (dis.HoraInicio == 0 && dis.HoraFim == 0)
                        {
                            continue;
                        }

                        if (dis.MinutoInicio != 0 && dis.MinutoInicio != 30)
                        {

                            if (dis.MinutoInicio > 30)
                            {
                                dis.MinutoInicio = 30;
                                dis.MinutoFim = 30;
                            }
                            else
                            {
                                dis.MinutoInicio = 0;
                                dis.MinutoFim = 0;
                            }
                        }

                        string ini = $"{dis.HoraInicio:D2}:{dis.MinutoInicio:D2}";
                        string fim = $"{dis.HoraFim:D2}:{dis.MinutoFim:D2}";

                        int startIndex = newHours.IndexOf(ini);
                        int endIndex = newHours.IndexOf(fim);

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            if (dis.Atendimento)
                            {
                                grid.Rows[i].Cells[column].Style.BackColor = 
                                System.Drawing.ColorTranslator.FromHtml("#FFF1A6");
                            }
                            else
                            {
                                grid.Rows[i].Cells[column].Style.BackColor = 
                                System.Drawing.ColorTranslator.FromHtml("#FCCECE");
                            }
                        }

                    }

                    for (int i = 0; i < days.Count; i++)
                    {
                        grid.Columns[i].HeaderText = days[i].ToString();
                    }

                }
                else
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível agendar, verifique se há algum campo vazio");
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MenuSingleton.Instance.MenuVisible();
            Close();

        }

        private void Calendario_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuSingleton.Instance.MenuVisible();
        }
    }
}
