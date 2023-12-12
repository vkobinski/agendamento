using AgendamentoCliente.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendamentoCliente.Telas
{
    public partial class EditaPaciente : Form
    {

        private long id;
        private Paciente pacienteForm;
        public EditaPaciente(long id, Paciente p)
        {
            this.id = id;
            this.pacienteForm = p;
            InitializeComponent();

            txbNomePaciente.Text = p.NomeCompleto;
            txbDataNascimento.Text = p.DataNascimento.ToString("dd/MM/yyyy");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuSingleton.Instance.MenuVisible();
            Close();
        }

        private async Task enviarForm()
        {
            var nome = txbNomePaciente.Text;
            var dataNascimento = txbDataNascimento.Text;

            HttpClient httpClient = new HttpClient();

            MultipartFormDataContent formData = new MultipartFormDataContent();

            try
            {

                if (nome.Length > 0) formData.Add(new StringContent(nome), "nomeCompleto");
                if (dataNascimento.Length > 0) formData.Add(new StringContent(dataNascimento), "dataNascimento");

                HttpResponseMessage response = await httpClient.PutAsync(Utils.GetIp("/api/v1/paciente/form/" + id), formData);
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Não foi possível cadastrar, verifique se há algum campo vazio");
                }
                else
                {
                    MenuSingleton.Instance.MenuVisible();
                    Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível cadastrar, verifique se há algum campo vazio");
            }
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {

            await enviarForm();
        }
    }
}
