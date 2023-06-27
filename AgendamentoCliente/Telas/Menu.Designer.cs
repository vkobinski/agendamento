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
            lbl2 = new Label();
            btnAgendar = new Button();
            btnDesmarcar = new Button();
            btnCadastrar = new Button();
            btnRemover = new Button();
            visualizaPaciente = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            DataNascimento = new DataGridViewTextBoxColumn();
            btnAtualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)visualizaPaciente).BeginInit();
            SuspendLayout();
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = SystemColors.ControlLightLight;
            lbl2.FlatStyle = FlatStyle.System;
            lbl2.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2.ForeColor = Color.FromArgb(76, 4, 44);
            lbl2.Location = new Point(60, 277);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(156, 29);
            lbl2.TabIndex = 1;
            lbl2.Text = "Lista Pacientes";
            // 
            // btnAgendar
            // 
            btnAgendar.FlatStyle = FlatStyle.Flat;
            btnAgendar.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgendar.ForeColor = SystemColors.ControlLightLight;
            btnAgendar.Image = Properties.Resources.btnEntrar;
            btnAgendar.Location = new Point(1059, 321);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(197, 46);
            btnAgendar.TabIndex = 2;
            btnAgendar.Text = "Agendar Paciente";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // btnDesmarcar
            // 
            btnDesmarcar.FlatStyle = FlatStyle.Flat;
            btnDesmarcar.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDesmarcar.ForeColor = SystemColors.ControlLightLight;
            btnDesmarcar.Image = Properties.Resources.btnEntrar;
            btnDesmarcar.Location = new Point(1059, 416);
            btnDesmarcar.Name = "btnDesmarcar";
            btnDesmarcar.Size = new Size(197, 46);
            btnDesmarcar.TabIndex = 3;
            btnDesmarcar.Text = "Desmarcar Paciente";
            btnDesmarcar.UseVisualStyleBackColor = true;
            btnDesmarcar.Click += btnDesmarcar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.ForeColor = SystemColors.ControlLightLight;
            btnCadastrar.Image = Properties.Resources.btnEntrar;
            btnCadastrar.Location = new Point(1059, 514);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(197, 46);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar Médico";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnRemover
            // 
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemover.ForeColor = SystemColors.ControlLightLight;
            btnRemover.Image = Properties.Resources.btnEntrar;
            btnRemover.Location = new Point(1059, 610);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(197, 46);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover Médico";
            btnRemover.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            visualizaPaciente.DefaultCellStyle = dataGridViewCellStyle2;
            visualizaPaciente.GridColor = Color.FromArgb(76, 4, 44);
            visualizaPaciente.Location = new Point(60, 321);
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
            visualizaPaciente.Size = new Size(943, 335);
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
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtualizar.ForeColor = SystemColors.ControlLightLight;
            btnAtualizar.Image = Properties.Resources.btnEntrar;
            btnAtualizar.Location = new Point(60, 685);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(197, 46);
            btnAtualizar.TabIndex = 7;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.telaMenu;
            ClientSize = new Size(1442, 999);
            Controls.Add(btnAtualizar);
            Controls.Add(visualizaPaciente);
            Controls.Add(btnRemover);
            Controls.Add(btnCadastrar);
            Controls.Add(btnDesmarcar);
            Controls.Add(btnAgendar);
            Controls.Add(lbl2);
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
            PerformLayout();
        }

        #endregion
        private Label lbl2;
        private Button btnAgendar;
        private Button btnDesmarcar;
        private Button btnCadastrar;
        private Button btnRemover;
        private DataGridView visualizaPaciente;
        private Button btnAtualizar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn DataNascimento;
    }
}