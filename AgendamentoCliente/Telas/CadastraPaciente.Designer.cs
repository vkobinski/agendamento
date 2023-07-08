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
            this.txbNomePaciente = new System.Windows.Forms.TextBox();
            this.dataNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbNomePaciente
            // 
            this.txbNomePaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNomePaciente.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNomePaciente.Location = new System.Drawing.Point(461, 427);
            this.txbNomePaciente.Name = "txbNomePaciente";
            this.txbNomePaciente.Size = new System.Drawing.Size(517, 26);
            this.txbNomePaciente.TabIndex = 2;
            // 
            // dataNascimento
            // 
            this.dataNascimento.CalendarFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataNascimento.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNascimento.Location = new System.Drawing.Point(461, 520);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(247, 33);
            this.dataNascimento.TabIndex = 8;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirmar.Image = global::AgendamentoCliente.Properties.Resources.btnEntrar;
            this.btnConfirmar.Location = new System.Drawing.Point(461, 646);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(200, 50);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Image = global::AgendamentoCliente.Properties.Resources.btnEntrar;
            this.btnCancelar.Location = new System.Drawing.Point(778, 646);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(200, 50);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // CadastraPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AgendamentoCliente.Properties.Resources.telaCadastroPaciente;
            this.ClientSize = new System.Drawing.Size(1442, 999);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.dataNascimento);
            this.Controls.Add(this.txbNomePaciente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastraPaciente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.CadastraPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txbNomePaciente;
        private DateTimePicker dataNascimento;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}