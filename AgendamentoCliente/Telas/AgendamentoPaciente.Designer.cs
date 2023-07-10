namespace AgendamentoCliente.Telas
{
    partial class AgendamentoPaciente
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.txbNomeMedico = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txbNomePaciente
            // 
            this.txbNomePaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNomePaciente.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNomePaciente.Location = new System.Drawing.Point(461, 379);
            this.txbNomePaciente.Name = "txbNomePaciente";
            this.txbNomePaciente.Size = new System.Drawing.Size(518, 26);
            this.txbNomePaciente.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Image = global::AgendamentoCliente.Properties.Resources.btnEntrar;
            this.btnCancelar.Location = new System.Drawing.Point(779, 693);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(200, 50);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgendar
            // 
            this.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgendar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgendar.Image = global::AgendamentoCliente.Properties.Resources.btnEntrar;
            this.btnAgendar.Location = new System.Drawing.Point(461, 693);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(200, 50);
            this.btnAgendar.TabIndex = 5;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click_2);
            // 
            // txbNomeMedico
            // 
            this.txbNomeMedico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNomeMedico.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNomeMedico.Location = new System.Drawing.Point(461, 479);
            this.txbNomeMedico.Name = "txbNomeMedico";
            this.txbNomeMedico.Size = new System.Drawing.Size(518, 26);
            this.txbNomeMedico.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.WindowText;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(461, 571);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(286, 33);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // AgendamentoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AgendamentoCliente.Properties.Resources.telaAgendamento;
            this.ClientSize = new System.Drawing.Size(1424, 791);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txbNomeMedico);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txbNomePaciente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgendamentoPaciente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendar";
            this.Load += new System.EventHandler(this.AgendamentoPaciente_Load_2);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txbNomePaciente;
        private Button btnCancelar;
        private Button btnAgendar;
        private TextBox txbNomeMedico;
        private DateTimePicker dateTimePicker1;
    }
}