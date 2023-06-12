namespace AgendamentoCliente.Telas
{
    partial class CadastraPaciente
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txbNomePaciente = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.dataNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(63, 81);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(134, 20);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Nome do Paciente:";
            // 
            // txbNomePaciente
            // 
            this.txbNomePaciente.Location = new System.Drawing.Point(203, 77);
            this.txbNomePaciente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbNomePaciente.Name = "txbNomePaciente";
            this.txbNomePaciente.Size = new System.Drawing.Size(282, 27);
            this.txbNomePaciente.TabIndex = 2;
            this.txbNomePaciente.TextChanged += new System.EventHandler(this.txbNomePaciente_TextChanged);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(63, 140);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(148, 20);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "Data de Nascimento:";
            // 
            // dataNascimento
            // 
            this.dataNascimento.Location = new System.Drawing.Point(203, 132);
            this.dataNascimento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(282, 27);
            this.dataNascimento.TabIndex = 8;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(203, 304);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(86, 31);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(400, 304);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 31);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // CadastraPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 408);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.dataNascimento);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txbNomePaciente);
            this.Controls.Add(this.lbl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastraPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastraPaciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl1;
        private TextBox txbNomePaciente;
        private Label lbl2;
        private DateTimePicker dataNascimento;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}