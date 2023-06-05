using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AgendamentoCliente.Telas
{
    public partial class CadastraMedico : Form
    {
        public CadastraMedico()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            //Adicionar Foto do Médico
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = string.Empty;
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                fotoMedico.Image = new Bitmap(open.FileName);

            }
        }

        private async Task enviarForm()
        {
            var nome = txbNomeMedico.Text;

            HttpClient httpClient = new HttpClient();

            // Create multipart form data content
            MultipartFormDataContent formData = new MultipartFormDataContent();

            // Add file to form data
            StreamContent fileContent = new StreamContent(File.OpenRead(fotoMedico.ImageLocation));
            formData.Add(fileContent, "foto", fotoMedico.Name);

            // Add additional form fields if needed
            formData.Add(new StringContent(nome), "nomeCompleto");

            try
            {
                // Send POST request to API endpoint
                HttpResponseMessage response = await httpClient.PostAsync("http://localhost:8080/api/v1/medico", formData);

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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Cadastrar Médico
            enviarForm();
            Close();
        }
    }
}
