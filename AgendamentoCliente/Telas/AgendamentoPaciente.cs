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
    public partial class AgendamentoPaciente : Form
    {
        public AgendamentoPaciente()
        {
            InitializeComponent();

            txbNomePaciente.AutoCompleteMode = AutoCompleteMode.Suggest;
            txbNomePaciente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txbNomePaciente.AutoCompleteCustomSource.AddRange(new string[] {
                "Gabriel Vilarino Gonçalves",
                "Gabriel Almeida",
                "Luiz Carlos",
                "Luiz Fernando",
                "Gabriel Santos",
                "Gabriel Eduardo"});

            txbNomeMedico.AutoCompleteMode = AutoCompleteMode.Suggest;
            txbNomeMedico.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txbNomeMedico.AutoCompleteCustomSource.AddRange(new string[] { "medico1", "medico2", "medico3" });
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            //Agendamento Utilizando o Banco de Dados
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Telas.CadastraPaciente cp = new Telas.CadastraPaciente();
            cp.Show();
        }

        private void txbNomePaciente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txbNomeMedico_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgendamentoPaciente_Load(object sender, EventArgs e)
        {

        }
    }
}
