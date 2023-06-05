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
    public partial class DesmarcaPaciente : Form
    {
        public DesmarcaPaciente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            //Desmarcar um Paciente Agendado
        }

        private void txbNomePaciente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
