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
            ((System.ComponentModel.ISupportInitialize)visualizaMedico).BeginInit();
            SuspendLayout();
            // 
            // txbNomeMedico
            // 
            txbNomeMedico.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbNomeMedico.Location = new Point(588, 297);
            txbNomeMedico.Name = "txbNomeMedico";
            txbNomeMedico.Size = new Size(247, 33);
            txbNomeMedico.TabIndex = 5;
            // 
            // btnRemover
            // 
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemover.ForeColor = SystemColors.ControlLightLight;
            btnRemover.Image = Properties.Resources.btnEntrar;
            btnRemover.Location = new Point(459, 749);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(200, 50);
            btnRemover.TabIndex = 7;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Image = Properties.Resources.btnEntrar;
            btnCancelar.Location = new Point(783, 749);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(200, 50);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = SystemColors.ControlLightLight;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPesquisar.ForeColor = SystemColors.ControlLightLight;
            btnPesquisar.Image = Properties.Resources.btnEntrar;
            btnPesquisar.Location = new Point(851, 301);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(107, 29);
            btnPesquisar.TabIndex = 9;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.TextAlign = ContentAlignment.BottomCenter;
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // visualizaMedico
            // 
            visualizaMedico.BackgroundColor = SystemColors.ControlLightLight;
            visualizaMedico.BorderStyle = BorderStyle.None;
            visualizaMedico.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            visualizaMedico.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(76, 4, 44);
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
            visualizaMedico.GridColor = Color.FromArgb(76, 4, 44);
            visualizaMedico.Location = new Point(450, 426);
            visualizaMedico.Margin = new Padding(3, 2, 3, 2);
            visualizaMedico.Name = "visualizaMedico";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(76, 4, 44);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            visualizaMedico.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            visualizaMedico.RowHeadersVisible = false;
            visualizaMedico.RowHeadersWidth = 51;
            visualizaMedico.RowTemplate.Height = 45;
            visualizaMedico.Size = new Size(533, 80);
            visualizaMedico.TabIndex = 10;
            visualizaMedico.CellContentClick += dataGridView1_CellContentClick;
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
            medicoExcluido.AutoSize = true;
            medicoExcluido.BackColor = SystemColors.ControlLightLight;
            medicoExcluido.Location = new Point(640, 559);
            medicoExcluido.Name = "medicoExcluido";
            medicoExcluido.Size = new Size(186, 15);
            medicoExcluido.TabIndex = 11;
            medicoExcluido.Text = "Médico foi excluído com sucesso!";
            medicoExcluido.Visible = false;
            // 
            // RemoveMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.telaRemoveMedico;
            ClientSize = new Size(1442, 999);
            Controls.Add(medicoExcluido);
            Controls.Add(visualizaMedico);
            Controls.Add(btnPesquisar);
            Controls.Add(btnCancelar);
            Controls.Add(btnRemover);
            Controls.Add(txbNomeMedico);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RemoveMedico";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Remover Médico";
            Load += RemoveMedico_Load;
            ((System.ComponentModel.ISupportInitialize)visualizaMedico).EndInit();
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
    }
}