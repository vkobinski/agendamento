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
            txbNomePaciente = new TextBox();
            btnCancelar = new Button();
            btnAgendar = new Button();
            txbNomeMedico = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // txbNomePaciente
            // 
            txbNomePaciente.BorderStyle = BorderStyle.None;
            txbNomePaciente.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbNomePaciente.Location = new Point(461, 379);
            txbNomePaciente.Name = "txbNomePaciente";
            txbNomePaciente.Size = new Size(518, 26);
            txbNomePaciente.TabIndex = 1;
            txbNomePaciente.TextChanged += txbNomePaciente_TextChanged_1;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Image = Properties.Resources.btnEntrar;
            btnCancelar.Location = new Point(779, 693);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(200, 50);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnAgendar
            // 
            btnAgendar.FlatStyle = FlatStyle.Flat;
            btnAgendar.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgendar.ForeColor = SystemColors.ControlLightLight;
            btnAgendar.Image = Properties.Resources.btnEntrar;
            btnAgendar.Location = new Point(461, 693);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(200, 50);
            btnAgendar.TabIndex = 5;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click_1;
            // 
            // txbNomeMedico
            // 
            txbNomeMedico.BorderStyle = BorderStyle.None;
            txbNomeMedico.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbNomeMedico.Location = new Point(461, 479);
            txbNomeMedico.Name = "txbNomeMedico";
            txbNomeMedico.Size = new Size(518, 26);
            txbNomeMedico.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.CalendarForeColor = SystemColors.WindowText;
            dateTimePicker1.CalendarTitleForeColor = SystemColors.ControlText;
            dateTimePicker1.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(461, 571);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.MaxDate = new DateTime(3000, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(286, 33);
            dateTimePicker1.TabIndex = 11;
            // 
            // AgendamentoPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.telaAgendamento;
            ClientSize = new Size(1424, 985);
            Controls.Add(dateTimePicker1);
            Controls.Add(txbNomeMedico);
            Controls.Add(btnAgendar);
            Controls.Add(btnCancelar);
            Controls.Add(txbNomePaciente);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AgendamentoPaciente";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agendar";
            Load += AgendamentoPaciente_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txbNomePaciente;
        private Button btnCancelar;
        private Button btnAgendar;
        private TextBox txbNomeMedico;
        private DateTimePicker dateTimePicker1;
    }
}