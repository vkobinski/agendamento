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
            lbl1 = new Label();
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
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(55, 61);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(103, 15);
            lbl1.TabIndex = 2;
            lbl1.Text = "Nome do Médico:";
            lbl1.Click += lbl1_Click;
            // 
            // txbNomeMedico
            // 
            txbNomeMedico.Location = new Point(164, 58);
            txbNomeMedico.Name = "txbNomeMedico";
            txbNomeMedico.Size = new Size(247, 23);
            txbNomeMedico.TabIndex = 5;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(164, 229);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(101, 23);
            btnRemover.TabIndex = 7;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(310, 229);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(450, 58);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 9;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // visualizaMedico
            // 
            visualizaMedico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            visualizaMedico.Columns.AddRange(new DataGridViewColumn[] { Nome, Id });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            visualizaMedico.DefaultCellStyle = dataGridViewCellStyle1;
            visualizaMedico.Location = new Point(10, 86);
            visualizaMedico.Margin = new Padding(3, 2, 3, 2);
            visualizaMedico.Name = "visualizaMedico";
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
            medicoExcluido.Location = new Point(186, 191);
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
            ClientSize = new Size(554, 306);
            Controls.Add(medicoExcluido);
            Controls.Add(visualizaMedico);
            Controls.Add(btnPesquisar);
            Controls.Add(btnCancelar);
            Controls.Add(btnRemover);
            Controls.Add(txbNomeMedico);
            Controls.Add(lbl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RemoveMedico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Remover";
            Load += RemoveMedico_Load;
            ((System.ComponentModel.ISupportInitialize)visualizaMedico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
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