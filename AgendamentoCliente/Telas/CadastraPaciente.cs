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
    public partial class CadastraPaciente : Form
    {
        public CadastraPaciente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async Task enviarForm()
        {
            var nome = txbNomePaciente.Text;
            var dataPaciente = dataNascimento.Value;
            var dataFormulario = dataPaciente.ToString().Split(" ")[0];

            HttpClient httpClient = new HttpClient();

            Dictionary<string, string> formData = new Dictionary<string, string>
        {
            { "nomeCompleto",  nome},
            { "dataNascimento", dataFormulario },
        };
            var content = new FormUrlEncodedContent(formData);
            try
            {
                // Send POST request to API endpoint
                HttpResponseMessage response = await httpClient.PostAsync("http://localhost:8080/api/v1/paciente/form", content);

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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            enviarForm();
            Close();
        }

        private void dataNascimento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
