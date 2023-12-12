using AgendamentoCliente.Models;
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
    public partial class ListaPaciente : Form
    {
        public ListaPaciente()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MenuSingleton.Instance.MenuVisible();
            Close();
        }

        private void btnEditarPaciente_Click(object sender, EventArgs e)
        {
            Telas.EditaPaciente ep = new Telas.EditaPaciente();
            ep.Show();
            this.Visible = false;
        }
    }
}
