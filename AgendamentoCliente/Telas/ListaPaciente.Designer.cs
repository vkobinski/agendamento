namespace AgendamentoCliente.Telas
{
    partial class ListaPaciente
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            visualizaPaciente = new DataGridView();
            idAtendimento = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            btnEditarPaciente = new Button();
            btnRemoverPaciente = new Button();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)visualizaPaciente).BeginInit();
            SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 140, 241);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1648, 119);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Calibri", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(1, 140, 241);
            label1.Location = new Point(674, 221);
            label1.Name = "label1";
            label1.Size = new Size(347, 54);
            label1.TabIndex = 12;
            label1.Text = "Lista de Pacientes";
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
            visualizaPaciente.Columns.AddRange(new DataGridViewColumn[] { idAtendimento, ID, status });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            visualizaPaciente.DefaultCellStyle = dataGridViewCellStyle2;
            visualizaPaciente.GridColor = Color.FromArgb(1, 140, 241);
            visualizaPaciente.Location = new Point(239, 361);
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
            visualizaPaciente.Size = new Size(1170, 332);
            visualizaPaciente.TabIndex = 13;
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
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID.HeaderText = "Paciente";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // status
            // 
            status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            status.HeaderText = "Data de Nascimento";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // btnEditarPaciente
            // 
            btnEditarPaciente.Anchor = AnchorStyles.None;
            btnEditarPaciente.BackColor = Color.FromArgb(1, 140, 241);
            btnEditarPaciente.FlatStyle = FlatStyle.Flat;
            btnEditarPaciente.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarPaciente.ForeColor = SystemColors.ControlLightLight;
            btnEditarPaciente.Location = new Point(686, 811);
            btnEditarPaciente.Margin = new Padding(3, 4, 3, 4);
            btnEditarPaciente.Name = "btnEditarPaciente";
            btnEditarPaciente.Size = new Size(278, 53);
            btnEditarPaciente.TabIndex = 18;
            btnEditarPaciente.Text = "Editar Paciente";
            btnEditarPaciente.UseVisualStyleBackColor = false;
            btnEditarPaciente.Click += btnEditarPaciente_Click;
            // 
            // btnRemoverPaciente
            // 
            btnRemoverPaciente.Anchor = AnchorStyles.None;
            btnRemoverPaciente.BackColor = Color.FromArgb(1, 140, 241);
            btnRemoverPaciente.FlatStyle = FlatStyle.Flat;
            btnRemoverPaciente.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemoverPaciente.ForeColor = SystemColors.ControlLightLight;
            btnRemoverPaciente.Location = new Point(686, 713);
            btnRemoverPaciente.Margin = new Padding(3, 4, 3, 4);
            btnRemoverPaciente.Name = "btnRemoverPaciente";
            btnRemoverPaciente.Size = new Size(278, 53);
            btnRemoverPaciente.TabIndex = 17;
            btnRemoverPaciente.Text = "Remover Paciente";
            btnRemoverPaciente.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.None;
            btnVoltar.BackColor = Color.FromArgb(1, 140, 241);
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.ForeColor = SystemColors.ControlLightLight;
            btnVoltar.Location = new Point(686, 908);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(278, 53);
            btnVoltar.TabIndex = 16;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // ListaPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1648, 1055);
            Controls.Add(btnEditarPaciente);
            Controls.Add(btnRemoverPaciente);
            Controls.Add(visualizaPaciente);
            Controls.Add(btnVoltar);
            Controls.Add(label1);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "ListaPaciente";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaPaciente";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)visualizaPaciente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private DataGridView visualizaPaciente;
        private DataGridViewTextBoxColumn idAtendimento;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn status;
        private Button btnEditarPaciente;
        private Button btnRemoverPaciente;
        private Button btnVoltar;
    }
}