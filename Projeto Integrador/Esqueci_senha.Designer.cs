namespace Projeto_Integrador
{
    partial class Esqueci_senha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Esqueci_senha));
            tb_email = new TextBox();
            tb_cpf = new TextBox();
            label1 = new Label();
            label2 = new Label();
            bt_verificar = new Button();
            tb_senha = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            fechar_programa = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)fechar_programa).BeginInit();
            SuspendLayout();
            // 
            // tb_email
            // 
            tb_email.Location = new Point(152, 79);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(282, 23);
            tb_email.TabIndex = 0;
            // 
            // tb_cpf
            // 
            tb_cpf.Location = new Point(152, 141);
            tb_cpf.Name = "tb_cpf";
            tb_cpf.Size = new Size(282, 23);
            tb_cpf.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 61);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "E-mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 123);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 3;
            label2.Text = "CPF";
            // 
            // bt_verificar
            // 
            bt_verificar.Location = new Point(359, 242);
            bt_verificar.Name = "bt_verificar";
            bt_verificar.Size = new Size(75, 23);
            bt_verificar.TabIndex = 4;
            bt_verificar.Text = "Verificar";
            bt_verificar.UseVisualStyleBackColor = true;
            // 
            // tb_senha
            // 
            tb_senha.Location = new Point(152, 192);
            tb_senha.Name = "tb_senha";
            tb_senha.ReadOnly = true;
            tb_senha.Size = new Size(282, 23);
            tb_senha.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 174);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 7;
            label3.Text = "SENHA";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(593, 335);
            panel1.TabIndex = 8;
            // 
            // fechar_programa
            // 
            fechar_programa.BackColor = Color.Transparent;
            fechar_programa.Image = (Image)resources.GetObject("fechar_programa.Image");
            fechar_programa.Location = new Point(518, 12);
            fechar_programa.Name = "fechar_programa";
            fechar_programa.Size = new Size(41, 45);
            fechar_programa.SizeMode = PictureBoxSizeMode.Zoom;
            fechar_programa.TabIndex = 5;
            fechar_programa.TabStop = false;
            fechar_programa.Click += fechar_programa_Click;
            // 
            // Esqueci_senha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 335);
            Controls.Add(fechar_programa);
            Controls.Add(label3);
            Controls.Add(tb_senha);
            Controls.Add(bt_verificar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_cpf);
            Controls.Add(tb_email);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Esqueci_senha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Esqueci_senha";
            Load += Esqueci_senha_Load;
            ((System.ComponentModel.ISupportInitialize)fechar_programa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_email;
        private TextBox tb_cpf;
        private Label label1;
        private Label label2;
        private Button bt_verificar;
        private TextBox tb_senha;
        private Label label3;
        private Panel panel1;
        private PictureBox fechar_programa;
    }
}