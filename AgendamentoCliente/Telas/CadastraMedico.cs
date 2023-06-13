﻿using System.Diagnostics;

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


        private async Task enviarForm()
        {
            var nome = txbNomeMedico.Text;

            HttpClient httpClient = new HttpClient();

            MultipartFormDataContent formData = new MultipartFormDataContent();

            StreamContent fileContent = new StreamContent(File.OpenRead(fotoMedico.ImageLocation));
            formData.Add(fileContent, "foto", fotoMedico.Name);

            formData.Add(new StringContent(nome), "nomeCompleto");


            Debug.WriteLine("Chegou");

            try
            {
                // Send POST request to API endpoint
                HttpResponseMessage response = await httpClient.PostAsync("http://localhost:8080/api/v1/medico/form", formData);

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

        private async void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            await enviarForm();
            Close();

        }

        private void fotoMedico_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnFoto_Click_1(object sender, EventArgs e)
        {
            //Adicionar Foto do Médico
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = string.Empty;
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                fotoMedico.Image = new Bitmap(open.FileName);
                fotoMedico.ImageLocation = open.FileName;
            }

        }
    }
}
