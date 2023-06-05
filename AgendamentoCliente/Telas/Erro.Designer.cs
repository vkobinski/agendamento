namespace AgendamentoCliente.Telas
{
    partial class Erro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Erro));
            lbl1 = new Label();
            bntOk = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.Location = new Point(44, 12);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(151, 17);
            lbl1.TabIndex = 0;
            lbl1.Text = "Login ou Senha Inválidos!";
            lbl1.Click += lbl1_Click;
            // 
            // bntOk
            // 
            bntOk.Location = new Point(67, 41);
            bntOk.Name = "bntOk";
            bntOk.Size = new Size(75, 23);
            bntOk.TabIndex = 1;
            bntOk.Text = "OK";
            bntOk.UseVisualStyleBackColor = true;
            bntOk.Click += bntOk_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.atencao;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Erro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(199, 76);
            Controls.Add(pictureBox1);
            Controls.Add(bntOk);
            Controls.Add(lbl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Erro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Erro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Button bntOk;
        private PictureBox pictureBox1;
    }
}