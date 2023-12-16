namespace AgendamentoCliente.Telas
{
    partial class RemoveMedico
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
            txbNomeMedico = new TextBox();
            btnRemover = new Button();
            btnCancelar = new Button();
            btnPesquisar = new Button();
            visualizaMedico = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            medicoExcluido = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)visualizaMedico).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txbNomeMedico
            // 
            txbNomeMedico.Anchor = AnchorStyles.None;
            txbNomeMedico.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbNomeMedico.Location = new Point(464, 287);
            txbNomeMedico.Name = "txbNomeMedico";
            txbNomeMedico.Size = new Size(385, 33);
            txbNomeMedico.TabIndex = 0;
            // 
            // btnRemover
            // 
            btnRemover.Anchor = AnchorStyles.None;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemover.ForeColor = SystemColors.ControlLightLight;
            btnRemover.Image = Properties.Resources.btnPrincipal;
            btnRemover.Location = new Point(464, 739);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(200, 50);
            btnRemover.TabIndex = 2;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click_2;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Image = Properties.Resources.btnPrincipal;
            btnCancelar.Location = new Point(788, 739);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(200, 50);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.None;
            btnPesquisar.BackColor = SystemColors.ControlLightLight;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPesquisar.ForeColor = SystemColors.ControlLightLight;
            btnPesquisar.Image = Properties.Resources.btnPrincipal;
            btnPesquisar.Location = new Point(881, 291);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(107, 29);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.TextAlign = ContentAlignment.BottomCenter;
            btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // visualizaMedico
            // 
            visualizaMedico.Anchor = AnchorStyles.None;
            visualizaMedico.BackgroundColor = SystemColors.ControlLightLight;
            visualizaMedico.BorderStyle = BorderStyle.None;
            visualizaMedico.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            visualizaMedico.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(1, 140, 241);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            visualizaMedico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            visualizaMedico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            visualizaMedico.Columns.AddRange(new DataGridViewColumn[] { Nome, Id });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            visualizaMedico.DefaultCellStyle = dataGridViewCellStyle2;
            visualizaMedico.GridColor = Color.FromArgb(1, 140, 241);
            visualizaMedico.Location = new Point(455, 416);
            visualizaMedico.Margin = new Padding(3, 2, 3, 2);
            visualizaMedico.Name = "visualizaMedico";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(1, 140, 241);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            visualizaMedico.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            visualizaMedico.RowHeadersVisible = false;
            visualizaMedico.RowHeadersWidth = 51;
            visualizaMedico.RowTemplate.Height = 45;
            visualizaMedico.Size = new Size(533, 80);
            visualizaMedico.TabIndex = 10;
            visualizaMedico.TabStop = false;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            // 
            // medicoExcluido
            // 
            medicoExcluido.Anchor = AnchorStyles.None;
            medicoExcluido.AutoSize = true;
            medicoExcluido.BackColor = SystemColors.ControlLightLight;
            medicoExcluido.Location = new Point(645, 549);
            medicoExcluido.Name = "medicoExcluido";
            medicoExcluido.Size = new Size(186, 15);
            medicoExcluido.TabIndex = 11;
            medicoExcluido.Text = "Médico foi excluído com sucesso!";
            medicoExcluido.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Calibri", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(1, 140, 241);
            label1.Location = new Point(581, 210);
            label1.Name = "label1";
            label1.Size = new Size(268, 42);
            label1.TabIndex = 12;
            label1.Text = "Remover Médico";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 140, 241);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1442, 89);
            panel1.TabIndex = 13;
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
            // RemoveMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1442, 999);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(medicoExcluido);
            Controls.Add(visualizaMedico);
            Controls.Add(btnPesquisar);
            Controls.Add(btnCancelar);
            Controls.Add(btnRemover);
            Controls.Add(txbNomeMedico);
            MaximizeBox = false;
            Name = "RemoveMedico";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Remover Médico";
            WindowState = FormWindowState.Maximized;
            FormClosing += RemoveMedico_FormClosing;
            ((System.ComponentModel.ISupportInitialize)visualizaMedico).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txbNomeMedico;
        private Button btnRemover;
        private Button btnCancelar;
        private Button btnPesquisar;
        private DataGridView visualizaMedico;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Id;
        private Label medicoExcluido;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}