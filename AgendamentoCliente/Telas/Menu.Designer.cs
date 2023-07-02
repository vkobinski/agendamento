namespace AgendamentoCliente.Telas
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnAgendar = new Button();
            btnDesmarcar = new Button();
            btnCadastrar = new Button();
            btnRemover = new Button();
            visualizaPaciente = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            DataNascimento = new DataGridViewTextBoxColumn();
            btnAtualizar = new Button();
            btnCadastrarPaciente = new Button();
            ((System.ComponentModel.ISupportInitialize)visualizaPaciente).BeginInit();
            SuspendLayout();
            // 
            // btnAgendar
            // 
            btnAgendar.BackColor = SystemColors.ControlLightLight;
            btnAgendar.FlatStyle = FlatStyle.Flat;
            btnAgendar.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgendar.ForeColor = SystemColors.ControlLightLight;
            btnAgendar.Image = Properties.Resources.btnEntrar;
            btnAgendar.Location = new Point(1109, 342);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(200, 48);
            btnAgendar.TabIndex = 2;
            btnAgendar.Text = "Agendar Paciente";
            btnAgendar.UseVisualStyleBackColor = false;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // btnDesmarcar
            // 
            btnDesmarcar.BackColor = SystemColors.ControlLightLight;
            btnDesmarcar.FlatStyle = FlatStyle.Flat;
            btnDesmarcar.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDesmarcar.ForeColor = SystemColors.ControlLightLight;
            btnDesmarcar.Image = Properties.Resources.btnEntrar;
            btnDesmarcar.Location = new Point(407, 740);
            btnDesmarcar.Name = "btnDesmarcar";
            btnDesmarcar.Size = new Size(200, 50);
            btnDesmarcar.TabIndex = 3;
            btnDesmarcar.Text = "Desmarcar Paciente";
            btnDesmarcar.UseVisualStyleBackColor = false;
            btnDesmarcar.Click += btnDesmarcar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.ControlLightLight;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.ForeColor = SystemColors.ControlLightLight;
            btnCadastrar.Image = Properties.Resources.btnEntrar;
            btnCadastrar.Location = new Point(1109, 437);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(200, 48);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar Médico";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = SystemColors.ControlLightLight;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemover.ForeColor = SystemColors.ControlLightLight;
            btnRemover.Image = Properties.Resources.btnEntrar;
            btnRemover.Location = new Point(1109, 528);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(200, 50);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover Médico";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // visualizaPaciente
            // 
            visualizaPaciente.BackgroundColor = SystemColors.ControlLightLight;
            visualizaPaciente.BorderStyle = BorderStyle.None;
            visualizaPaciente.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            visualizaPaciente.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(76, 4, 44);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            visualizaPaciente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            visualizaPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            visualizaPaciente.Columns.AddRange(new DataGridViewColumn[] { ID, Nome, DataNascimento });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            visualizaPaciente.DefaultCellStyle = dataGridViewCellStyle2;
            visualizaPaciente.GridColor = Color.FromArgb(76, 4, 44);
            visualizaPaciente.Location = new Point(138, 321);
            visualizaPaciente.Margin = new Padding(3, 2, 3, 2);
            visualizaPaciente.Name = "visualizaPaciente";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(76, 4, 44);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            visualizaPaciente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            visualizaPaciente.RowHeadersVisible = false;
            visualizaPaciente.RowHeadersWidth = 51;
            visualizaPaciente.RowTemplate.Height = 29;
            visualizaPaciente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            visualizaPaciente.Size = new Size(865, 335);
            visualizaPaciente.TabIndex = 6;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID.HeaderText = "Médico";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nome.HeaderText = "Paciente";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            // 
            // DataNascimento
            // 
            DataNascimento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataNascimento.HeaderText = "Data de Atendimento";
            DataNascimento.MinimumWidth = 6;
            DataNascimento.Name = "DataNascimento";
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = SystemColors.ControlLightLight;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtualizar.ForeColor = SystemColors.ControlLightLight;
            btnAtualizar.Image = Properties.Resources.btnEntrar;
            btnAtualizar.Location = new Point(138, 740);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(200, 50);
            btnAtualizar.TabIndex = 7;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnCadastrarPaciente
            // 
            btnCadastrarPaciente.BackColor = SystemColors.ControlLightLight;
            btnCadastrarPaciente.FlatStyle = FlatStyle.Flat;
            btnCadastrarPaciente.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrarPaciente.ForeColor = SystemColors.ControlLightLight;
            btnCadastrarPaciente.Image = Properties.Resources.btnEntrar;
            btnCadastrarPaciente.Location = new Point(1109, 623);
            btnCadastrarPaciente.Name = "btnCadastrarPaciente";
            btnCadastrarPaciente.Size = new Size(200, 50);
            btnCadastrarPaciente.TabIndex = 8;
            btnCadastrarPaciente.Text = "Cadastrar Paciente";
            btnCadastrarPaciente.UseVisualStyleBackColor = false;
            btnCadastrarPaciente.Click += btnCadastrarPaciente_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.TelaMenu1;
            ClientSize = new Size(1442, 999);
            Controls.Add(btnCadastrarPaciente);
            Controls.Add(btnAtualizar);
            Controls.Add(visualizaPaciente);
            Controls.Add(btnRemover);
            Controls.Add(btnCadastrar);
            Controls.Add(btnDesmarcar);
            Controls.Add(btnAgendar);
            MaximizeBox = false;
            Name = "Menu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Activated += Menu_Activated;
            FormClosed += Menu_FormClosed;
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)visualizaPaciente).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAgendar;
        private Button btnDesmarcar;
        private Button btnCadastrar;
        private Button btnRemover;
        private DataGridView visualizaPaciente;
        private Button btnAtualizar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn DataNascimento;
        private Button btnCadastrarPaciente;
    }
}