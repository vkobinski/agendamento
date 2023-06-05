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
            lbl1 = new Label();
            txbNomeMedico = new TextBox();
            btnRemover = new Button();
            btnCancelar = new Button();
            btnPesquisar = new Button();
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
            btnRemover.Click += btnRemover_Click;
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
            // 
            // RemoveMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 306);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txbNomeMedico;
        private Button btnRemover;
        private Button btnCancelar;
        private Button btnPesquisar;
    }
}