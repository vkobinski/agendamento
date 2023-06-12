using AgendamentoCliente.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync("http://localhost:8080/api/v1/paciente");

            string v = await httpResponseMessage.Content.ReadAsStringAsync();

            List<Paciente> pacienteLista = JsonConvert.DeserializeObject<List<Paciente>>(v);

            DataGridViewRow linha = new DataGridViewRow();
            pacienteLista.ForEach(paciente =>
            {


            DataGridViewTextBoxCell nomeCelula = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell idCelula = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell dataCelula = new DataGridViewTextBoxCell();



                nomeCelula.Value = paciente.NomeCompleto;
                idCelula.Value = paciente.PacienteId;
                dataCelula.Value = paciente.DataNascimento;

                linha.Cells.AddRange(nomeCelula, idCelula, dataCelula);

                visualizaPaciente.Rows.Add(linha);

            });

        }
    }
}
