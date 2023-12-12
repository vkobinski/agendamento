﻿namespace AgendamentoCliente.Telas
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
            txbNomePaciente = new TextBox();
            dataNascimento = new DateTimePicker();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            panel13 = new Panel();
            panel14 = new Panel();
            panel15 = new Panel();
            panel16 = new Panel();
            panel17 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel15.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // txbNomePaciente
            // 
            txbNomePaciente.Anchor = AnchorStyles.None;
            txbNomePaciente.BorderStyle = BorderStyle.None;
            txbNomePaciente.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbNomePaciente.Location = new Point(530, 415);
            txbNomePaciente.Margin = new Padding(3, 4, 3, 4);
            txbNomePaciente.Name = "txbNomePaciente";
            txbNomePaciente.Size = new Size(591, 33);
            txbNomePaciente.TabIndex = 0;
            // 
            // dataNascimento
            // 
            dataNascimento.Anchor = AnchorStyles.None;
            dataNascimento.CalendarFont = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dataNascimento.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataNascimento.Format = DateTimePickerFormat.Short;
            dataNascimento.Location = new Point(530, 539);
            dataNascimento.Margin = new Padding(3, 4, 3, 4);
            dataNascimento.Name = "dataNascimento";
            dataNascimento.Size = new Size(588, 40);
            dataNascimento.TabIndex = 1;
            dataNascimento.KeyPress += dataNascimento_KeyPress;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.None;
            btnConfirmar.BackColor = Color.FromArgb(1, 140, 241);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.ForeColor = SystemColors.ControlLightLight;
            btnConfirmar.Location = new Point(530, 761);
            btnConfirmar.Margin = new Padding(3, 4, 3, 4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(229, 55);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.FromArgb(1, 140, 241);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(893, 761);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(229, 55);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 140, 241);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1648, 119);
            panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(157, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 103);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Calibri", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(1, 140, 241);
            label1.Location = new Point(661, 280);
            label1.Name = "label1";
            label1.Size = new Size(296, 54);
            label1.TabIndex = 16;
            label1.Text = "Editar Paciente";
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.None;
            panel10.BackColor = Color.FromArgb(1, 140, 241);
            panel10.Controls.Add(panel11);
            panel10.Controls.Add(panel15);
            panel10.Controls.Add(panel17);
            panel10.Location = new Point(531, 449);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(589, 1);
            panel10.TabIndex = 19;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(1, 140, 241);
            panel11.Controls.Add(panel12);
            panel11.Controls.Add(panel14);
            panel11.Location = new Point(0, 137);
            panel11.Margin = new Padding(3, 4, 3, 4);
            panel11.Name = "panel11";
            panel11.Size = new Size(360, 1);
            panel11.TabIndex = 17;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(1, 140, 241);
            panel12.Controls.Add(panel13);
            panel12.Location = new Point(0, 63);
            panel12.Margin = new Padding(3, 4, 3, 4);
            panel12.Name = "panel12";
            panel12.Size = new Size(360, 1);
            panel12.TabIndex = 16;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(1, 140, 241);
            panel13.Location = new Point(0, 0);
            panel13.Margin = new Padding(3, 4, 3, 4);
            panel13.Name = "panel13";
            panel13.Size = new Size(360, 1);
            panel13.TabIndex = 15;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(1, 140, 241);
            panel14.Location = new Point(0, 0);
            panel14.Margin = new Padding(3, 4, 3, 4);
            panel14.Name = "panel14";
            panel14.Size = new Size(360, 1);
            panel14.TabIndex = 15;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(1, 140, 241);
            panel15.Controls.Add(panel16);
            panel15.Location = new Point(0, 63);
            panel15.Margin = new Padding(3, 4, 3, 4);
            panel15.Name = "panel15";
            panel15.Size = new Size(360, 1);
            panel15.TabIndex = 16;
            // 
            // panel16
            // 
            panel16.BackColor = Color.FromArgb(1, 140, 241);
            panel16.Location = new Point(0, 0);
            panel16.Margin = new Padding(3, 4, 3, 4);
            panel16.Name = "panel16";
            panel16.Size = new Size(360, 1);
            panel16.TabIndex = 15;
            // 
            // panel17
            // 
            panel17.BackColor = Color.FromArgb(1, 140, 241);
            panel17.Location = new Point(0, 29);
            panel17.Margin = new Padding(3, 4, 3, 4);
            panel17.Name = "panel17";
            panel17.Size = new Size(360, 1);
            panel17.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(1, 140, 241);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel9);
            panel2.Location = new Point(530, 583);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(589, 1);
            panel2.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(1, 140, 241);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel6);
            panel3.Location = new Point(0, 137);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(360, 1);
            panel3.TabIndex = 17;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(1, 140, 241);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(0, 63);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(360, 1);
            panel4.TabIndex = 16;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(1, 140, 241);
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(360, 1);
            panel5.TabIndex = 15;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(1, 140, 241);
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(360, 1);
            panel6.TabIndex = 15;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(1, 140, 241);
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(0, 63);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(360, 1);
            panel7.TabIndex = 16;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(1, 140, 241);
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(360, 1);
            panel8.TabIndex = 15;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(1, 140, 241);
            panel9.Location = new Point(0, 29);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(360, 1);
            panel9.TabIndex = 15;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(1, 140, 241);
            label3.Location = new Point(527, 587);
            label3.Name = "label3";
            label3.Size = new Size(241, 33);
            label3.TabIndex = 20;
            label3.Text = "Data de Nascimento";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(1, 140, 241);
            label2.Location = new Point(528, 453);
            label2.Name = "label2";
            label2.Size = new Size(90, 33);
            label2.TabIndex = 18;
            label2.Text = "Nome ";
            // 
            // CadastraPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1648, 1055);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(panel10);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(dataNascimento);
            Controls.Add(txbNomePaciente);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "CadastraPaciente";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastramento";
            WindowState = FormWindowState.Maximized;
            FormClosing += CadastraPaciente_FormClosing;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txbNomePaciente;
        private DateTimePicker dataNascimento;
        private Button btnConfirmar;
        private Button btnCancelar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private Panel panel17;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Label label3;
        private Label label2;
    }
}