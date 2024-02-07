namespace AgendamentoCliente.Telas
{
    partial class ListaMedico
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            visualizaPaciente = new DataGridView();
            idAtendimento = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            senha = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            btnVoltar = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visualizaPaciente).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 140, 241);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1442, 89);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(137, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 77);
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
            label1.Location = new Point(590, 166);
            label1.Name = "label1";
            label1.Size = new Size(263, 42);
            label1.TabIndex = 11;
            label1.Text = "Lista de Médicos";
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(1, 140, 241);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            visualizaPaciente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            visualizaPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            visualizaPaciente.Columns.AddRange(new DataGridViewColumn[] { idAtendimento, ID, email, senha, status });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            visualizaPaciente.DefaultCellStyle = dataGridViewCellStyle2;
            visualizaPaciente.GridColor = Color.FromArgb(1, 140, 241);
            visualizaPaciente.Location = new Point(209, 244);
            visualizaPaciente.Margin = new Padding(3, 2, 3, 2);
            visualizaPaciente.MultiSelect = false;
            visualizaPaciente.Name = "visualizaPaciente";
            visualizaPaciente.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(1, 140, 241);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            visualizaPaciente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            visualizaPaciente.RowHeadersVisible = false;
            visualizaPaciente.RowHeadersWidth = 51;
            visualizaPaciente.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            visualizaPaciente.RowTemplate.Height = 29;
            visualizaPaciente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            visualizaPaciente.Size = new Size(1024, 249);
            visualizaPaciente.TabIndex = 12;
            visualizaPaciente.TabStop = false;
            // 
            // idAtendimento
            // 
            idAtendimento.HeaderText = "ID";
            idAtendimento.Name = "idAtendimento";
            idAtendimento.ReadOnly = true;
            idAtendimento.Visible = false;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID.HeaderText = "Médico";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // email
            // 
            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            email.HeaderText = "Email";
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // senha
            // 
            senha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            senha.HeaderText = "Senha";
            senha.Name = "senha";
            senha.ReadOnly = true;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.None;
            btnVoltar.BackColor = Color.FromArgb(1, 140, 241);
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.ForeColor = SystemColors.ControlLightLight;
            btnVoltar.Location = new Point(600, 757);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(243, 40);
            btnVoltar.TabIndex = 13;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(1, 140, 241);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(600, 535);
            button1.Name = "button1";
            button1.Size = new Size(243, 40);
            button1.TabIndex = 14;
            button1.Text = "Mudar Status";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnDesmarcar_Click_1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(1, 140, 241);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(600, 609);
            button2.Name = "button2";
            button2.Size = new Size(243, 40);
            button2.TabIndex = 15;
            button2.Text = "Editar Médico";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(1, 140, 241);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(600, 683);
            button3.Name = "button3";
            button3.Size = new Size(243, 40);
            button3.TabIndex = 16;
            button3.Text = "Calendário";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // ListaMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1442, 857);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnVoltar);
            Controls.Add(visualizaPaciente);
            Controls.Add(label1);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "ListaMedico";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaMedico";
            WindowState = FormWindowState.Maximized;
            FormClosing += ListaMedico_FormClosing;
            Load += ListaMedico_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)visualizaPaciente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView visualizaPaciente;
        private Button btnVoltar;
        private Button button1;
        private DataGridViewTextBoxColumn idAtendimento;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn senha;
        private DataGridViewTextBoxColumn status;
        private Button button2;
        private Button button3;
    }
}