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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnAgendar = new Button();
            btnDesmarcar = new Button();
            btnCadastrar = new Button();
            visualizaPaciente = new DataGridView();
            idAtendimento = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            DataNascimento = new DataGridViewTextBoxColumn();
            btnAtualizar = new Button();
            btnCadastrarPaciente = new Button();
            textBox1 = new TextBox();
            btnBuscar = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnListaMedico = new Button();
            btnListaPaciente = new Button();
            ((System.ComponentModel.ISupportInitialize)visualizaPaciente).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAgendar
            // 
            btnAgendar.Anchor = AnchorStyles.None;
            btnAgendar.BackColor = Color.FromArgb(1, 140, 241);
            btnAgendar.FlatStyle = FlatStyle.Flat;
            btnAgendar.Font = new Font("Calibri", 14.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgendar.ForeColor = SystemColors.ControlLightLight;
            btnAgendar.Location = new Point(1286, 347);
            btnAgendar.Margin = new Padding(3, 4, 3, 4);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(229, 64);
            btnAgendar.TabIndex = 0;
            btnAgendar.Text = "Agendar Paciente";
            btnAgendar.UseVisualStyleBackColor = false;
            btnAgendar.Click += btnAgendar_Click_1;
            // 
            // btnDesmarcar
            // 
            btnDesmarcar.Anchor = AnchorStyles.None;
            btnDesmarcar.BackColor = Color.FromArgb(1, 140, 241);
            btnDesmarcar.FlatStyle = FlatStyle.Flat;
            btnDesmarcar.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDesmarcar.ForeColor = SystemColors.ControlLightLight;
            btnDesmarcar.Location = new Point(440, 879);
            btnDesmarcar.Margin = new Padding(3, 4, 3, 4);
            btnDesmarcar.Name = "btnDesmarcar";
            btnDesmarcar.Size = new Size(229, 67);
            btnDesmarcar.TabIndex = 5;
            btnDesmarcar.Text = "Desmarcar Paciente";
            btnDesmarcar.UseVisualStyleBackColor = false;
            btnDesmarcar.Click += btnDesmarcar_Click_1;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.None;
            btnCadastrar.BackColor = Color.FromArgb(1, 140, 241);
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Calibri", 14.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.ForeColor = SystemColors.ControlLightLight;
            btnCadastrar.Location = new Point(1286, 455);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(229, 64);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar Médico";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click_1;
            // 
            // visualizaPaciente
            // 
            visualizaPaciente.AllowUserToAddRows = false;
            visualizaPaciente.AllowUserToDeleteRows = false;
            visualizaPaciente.AllowUserToResizeColumns = false;
            visualizaPaciente.AllowUserToResizeRows = false;
            visualizaPaciente.Anchor = AnchorStyles.None;
            visualizaPaciente.BackgroundColor = SystemColors.ControlLightLight;
            visualizaPaciente.BorderStyle = BorderStyle.None;
            visualizaPaciente.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            visualizaPaciente.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(1, 140, 241);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            visualizaPaciente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            visualizaPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            visualizaPaciente.Columns.AddRange(new DataGridViewColumn[] { idAtendimento, Nome, ID, DataNascimento });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            visualizaPaciente.DefaultCellStyle = dataGridViewCellStyle5;
            visualizaPaciente.GridColor = Color.FromArgb(1, 140, 241);
            visualizaPaciente.Location = new Point(141, 320);
            visualizaPaciente.MultiSelect = false;
            visualizaPaciente.Name = "visualizaPaciente";
            visualizaPaciente.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle6.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(1, 140, 241);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            visualizaPaciente.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            visualizaPaciente.RowHeadersVisible = false;
            visualizaPaciente.RowHeadersWidth = 51;
            visualizaPaciente.RowTemplate.Height = 29;
            visualizaPaciente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            visualizaPaciente.Size = new Size(938, 447);
            visualizaPaciente.TabIndex = 6;
            visualizaPaciente.TabStop = false;
            // 
            // idAtendimento
            // 
            idAtendimento.HeaderText = "ID";
            idAtendimento.MinimumWidth = 6;
            idAtendimento.Name = "idAtendimento";
            idAtendimento.ReadOnly = true;
            idAtendimento.Visible = false;
            idAtendimento.Width = 125;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nome.HeaderText = "Paciente";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID.HeaderText = "Médico";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // DataNascimento
            // 
            DataNascimento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataNascimento.HeaderText = "Data de Atendimento";
            DataNascimento.MinimumWidth = 6;
            DataNascimento.Name = "DataNascimento";
            DataNascimento.ReadOnly = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Anchor = AnchorStyles.None;
            btnAtualizar.BackColor = Color.FromArgb(1, 140, 241);
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtualizar.ForeColor = SystemColors.ControlLightLight;
            btnAtualizar.Location = new Point(141, 879);
            btnAtualizar.Margin = new Padding(3, 4, 3, 4);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(229, 67);
            btnAtualizar.TabIndex = 4;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click_1;
            // 
            // btnCadastrarPaciente
            // 
            btnCadastrarPaciente.Anchor = AnchorStyles.None;
            btnCadastrarPaciente.BackColor = Color.FromArgb(1, 140, 241);
            btnCadastrarPaciente.FlatStyle = FlatStyle.Flat;
            btnCadastrarPaciente.Font = new Font("Calibri", 14.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrarPaciente.ForeColor = SystemColors.ControlLightLight;
            btnCadastrarPaciente.Location = new Point(1286, 563);
            btnCadastrarPaciente.Margin = new Padding(3, 4, 3, 4);
            btnCadastrarPaciente.Name = "btnCadastrarPaciente";
            btnCadastrarPaciente.Size = new Size(229, 67);
            btnCadastrarPaciente.TabIndex = 3;
            btnCadastrarPaciente.Text = "Cadastrar Paciente";
            btnCadastrarPaciente.UseVisualStyleBackColor = false;
            btnCadastrarPaciente.Click += btnCadastrarPaciente_Click_1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(618, 251);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar";
            textBox1.Size = new Size(331, 38);
            textBox1.TabIndex = 7;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.BackColor = Color.FromArgb(1, 140, 241);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = SystemColors.ControlLightLight;
            btnBuscar.Location = new Point(970, 251);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(119, 43);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 140, 241);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1648, 119);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(157, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 103);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Calibri", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(1, 140, 241);
            label1.Location = new Point(141, 237);
            label1.Name = "label1";
            label1.Size = new Size(434, 54);
            label1.TabIndex = 10;
            label1.Text = "Lista de Atendimentos";
            // 
            // btnListaMedico
            // 
            btnListaMedico.Anchor = AnchorStyles.None;
            btnListaMedico.BackColor = Color.FromArgb(1, 140, 241);
            btnListaMedico.FlatStyle = FlatStyle.Flat;
            btnListaMedico.Font = new Font("Calibri", 14.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnListaMedico.ForeColor = SystemColors.ControlLightLight;
            btnListaMedico.Location = new Point(1286, 674);
            btnListaMedico.Margin = new Padding(3, 4, 3, 4);
            btnListaMedico.Name = "btnListaMedico";
            btnListaMedico.Size = new Size(229, 67);
            btnListaMedico.TabIndex = 11;
            btnListaMedico.Text = "Lista de Médicos";
            btnListaMedico.UseVisualStyleBackColor = false;
            btnListaMedico.Click += btnListaMedico_Click;
            // 
            // btnListaPaciente
            // 
            btnListaPaciente.Anchor = AnchorStyles.None;
            btnListaPaciente.BackColor = Color.FromArgb(1, 140, 241);
            btnListaPaciente.FlatStyle = FlatStyle.Flat;
            btnListaPaciente.Font = new Font("Calibri", 14.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnListaPaciente.ForeColor = SystemColors.ControlLightLight;
            btnListaPaciente.Location = new Point(1286, 785);
            btnListaPaciente.Margin = new Padding(3, 4, 3, 4);
            btnListaPaciente.Name = "btnListaPaciente";
            btnListaPaciente.Size = new Size(229, 67);
            btnListaPaciente.TabIndex = 12;
            btnListaPaciente.Text = "Lista de Pacientes";
            btnListaPaciente.UseVisualStyleBackColor = false;
            btnListaPaciente.Click += btnListaPaciente_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1648, 1055);
            Controls.Add(btnListaPaciente);
            Controls.Add(btnListaMedico);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnBuscar);
            Controls.Add(textBox1);
            Controls.Add(btnCadastrarPaciente);
            Controls.Add(btnAtualizar);
            Controls.Add(visualizaPaciente);
            Controls.Add(btnCadastrar);
            Controls.Add(btnDesmarcar);
            Controls.Add(btnAgendar);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Menu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            Activated += Menu_Activated;
            FormClosing += Menu_FormClosing;
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)visualizaPaciente).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAgendar;
        private Button btnDesmarcar;
        private Button btnCadastrar;
        private DataGridView visualizaPaciente;
        private Button btnAtualizar;
        private Button btnCadastrarPaciente;
        private TextBox textBox1;
        private Button btnBuscar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnListaMedico;
        private DataGridViewTextBoxColumn idAtendimento;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn DataNascimento;
        private Button btnListaPaciente;
    }
}