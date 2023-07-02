namespace AgendamentoCliente.Telas
{
    partial class DesmarcaPaciente
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
            dateTimePicker1 = new DateTimePicker();
            btnDesmarcar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txbNomePaciente
            // 
            txbNomePaciente.BorderStyle = BorderStyle.None;
            txbNomePaciente.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbNomePaciente.Location = new Point(462, 427);
            txbNomePaciente.Name = "txbNomePaciente";
            txbNomePaciente.Size = new Size(515, 26);
            txbNomePaciente.TabIndex = 4;
            txbNomePaciente.TextChanged += txbNomePaciente_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.ImeMode = ImeMode.NoControl;
            dateTimePicker1.Location = new Point(462, 519);
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(247, 33);
            dateTimePicker1.TabIndex = 5;
            // 
            // btnDesmarcar
            // 
            btnDesmarcar.BackColor = SystemColors.ControlLightLight;
            btnDesmarcar.FlatStyle = FlatStyle.Flat;
            btnDesmarcar.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDesmarcar.ForeColor = SystemColors.ControlLightLight;
            btnDesmarcar.Image = Properties.Resources.btnEntrar;
            btnDesmarcar.Location = new Point(460, 642);
            btnDesmarcar.Name = "btnDesmarcar";
            btnDesmarcar.Size = new Size(200, 50);
            btnDesmarcar.TabIndex = 6;
            btnDesmarcar.Text = "Desmarcar";
            btnDesmarcar.UseVisualStyleBackColor = false;
            btnDesmarcar.Click += btnDesmarcar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlLightLight;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Image = Properties.Resources.btnEntrar;
            btnCancelar.Location = new Point(777, 642);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(200, 50);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // DesmarcaPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.telaDesmarcaPaciente;
            ClientSize = new Size(1442, 999);
            Controls.Add(btnCancelar);
            Controls.Add(btnDesmarcar);
            Controls.Add(dateTimePicker1);
            Controls.Add(txbNomePaciente);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DesmarcaPaciente";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Desmarcar ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txbNomePaciente;
        private DateTimePicker dateTimePicker1;
        private Button btnDesmarcar;
        private Button btnCancelar;
    }
}