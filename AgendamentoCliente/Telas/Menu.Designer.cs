namespace AgendamentoCliente.Telas
{
    partial class Menu
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
            lbl2 = new Label();
            btnAgendar = new Button();
            btnDesmarcar = new Button();
            btnCadastrar = new Button();
            btnRemover = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.Location = new Point(296, 43);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(128, 23);
            lbl1.TabIndex = 0;
            lbl1.Text = "LAYOUT TESTE";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(24, 89);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(87, 15);
            lbl2.TabIndex = 1;
            lbl2.Text = "Lista Pacientes:";
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(584, 89);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(113, 23);
            btnAgendar.TabIndex = 2;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += button1_Click;
            // 
            // btnDesmarcar
            // 
            btnDesmarcar.Location = new Point(584, 133);
            btnDesmarcar.Name = "btnDesmarcar";
            btnDesmarcar.Size = new Size(113, 23);
            btnDesmarcar.TabIndex = 3;
            btnDesmarcar.Text = "Desmarcar";
            btnDesmarcar.UseVisualStyleBackColor = true;
            btnDesmarcar.Click += btnDesmarcar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(584, 173);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(113, 23);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar Médico";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(584, 215);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(113, 23);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover Médico";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 560);
            Controls.Add(btnRemover);
            Controls.Add(btnCadastrar);
            Controls.Add(btnDesmarcar);
            Controls.Add(btnAgendar);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            MaximizeBox = false;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BemVindo";
            FormClosed += Menu_FormClosed;
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private Button btnAgendar;
        private Button btnDesmarcar;
        private Button btnCadastrar;
        private Button btnRemover;
    }
}