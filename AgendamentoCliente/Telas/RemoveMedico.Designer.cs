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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txbNomeMedico = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.visualizaMedico = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicoExcluido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.visualizaMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(63, 81);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(129, 20);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Nome do Médico:";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // txbNomeMedico
            // 
            this.txbNomeMedico.Location = new System.Drawing.Point(187, 77);
            this.txbNomeMedico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbNomeMedico.Name = "txbNomeMedico";
            this.txbNomeMedico.Size = new System.Drawing.Size(282, 27);
            this.txbNomeMedico.TabIndex = 5;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(187, 305);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(115, 31);
            this.btnRemover.TabIndex = 7;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(354, 305);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 31);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(514, 77);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(86, 31);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // visualizaMedico
            // 
            this.visualizaMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visualizaMedico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Id});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.visualizaMedico.DefaultCellStyle = dataGridViewCellStyle1;
            this.visualizaMedico.Location = new System.Drawing.Point(12, 115);
            this.visualizaMedico.Name = "visualizaMedico";
            this.visualizaMedico.RowHeadersWidth = 51;
            this.visualizaMedico.RowTemplate.Height = 45;
            this.visualizaMedico.Size = new System.Drawing.Size(609, 107);
            this.visualizaMedico.TabIndex = 10;
            this.visualizaMedico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            // 
            // medicoExcluido
            // 
            this.medicoExcluido.AutoSize = true;
            this.medicoExcluido.Location = new System.Drawing.Point(213, 255);
            this.medicoExcluido.Name = "medicoExcluido";
            this.medicoExcluido.Size = new System.Drawing.Size(232, 20);
            this.medicoExcluido.TabIndex = 11;
            this.medicoExcluido.Text = "Médico foi excluído com sucesso!";
            this.medicoExcluido.Visible = false;
            // 
            // RemoveMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 408);
            this.Controls.Add(this.medicoExcluido);
            this.Controls.Add(this.visualizaMedico);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.txbNomeMedico);
            this.Controls.Add(this.lbl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemoveMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remover";
            this.Load += new System.EventHandler(this.RemoveMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visualizaMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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