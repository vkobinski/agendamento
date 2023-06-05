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
    public partial class RemoveMedico : Form
    {
        public RemoveMedico()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //Remover Médico
        }
    }
}
