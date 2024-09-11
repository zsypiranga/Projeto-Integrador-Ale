namespace Projeto_Integrador
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            fechar_programa = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            bt_login = new Button();
            tb_senha = new TextBox();
            tb_email = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fechar_programa).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(fechar_programa);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(593, 335);
            panel1.TabIndex = 0;
            // 
            // fechar_programa
            // 
            fechar_programa.BackColor = Color.Transparent;
            fechar_programa.Image = (Image)resources.GetObject("fechar_programa.Image");
            fechar_programa.Location = new Point(551, 2);
            fechar_programa.Name = "fechar_programa";
            fechar_programa.Size = new Size(41, 45);
            fechar_programa.SizeMode = PictureBoxSizeMode.Zoom;
            fechar_programa.TabIndex = 1;
            fechar_programa.TabStop = false;
            fechar_programa.Click += fechar_programa_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(bt_login);
            panel2.Controls.Add(tb_senha);
            panel2.Controls.Add(tb_email);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(314, 311);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(96, 279);
            label1.Name = "label1";
            label1.Size = new Size(121, 17);
            label1.TabIndex = 9;
            label1.Text = "Esqueci minha Senha";
            // 
            // bt_login
            // 
            bt_login.Location = new Point(52, 226);
            bt_login.Name = "bt_login";
            bt_login.Size = new Size(206, 34);
            bt_login.TabIndex = 8;
            bt_login.Text = "LOGAR";
            bt_login.UseVisualStyleBackColor = true;
            bt_login.Click += bt_login_Click;
            // 
            // tb_senha
            // 
            tb_senha.Font = new Font("Segoe UI", 12F);
            tb_senha.Location = new Point(52, 177);
            tb_senha.Multiline = true;
            tb_senha.Name = "tb_senha";
            tb_senha.PlaceholderText = "Senha";
            tb_senha.Size = new Size(206, 30);
            tb_senha.TabIndex = 7;
            // 
            // tb_email
            // 
            tb_email.Font = new Font("Segoe UI", 12F);
            tb_email.Location = new Point(52, 125);
            tb_email.Multiline = true;
            tb_email.Name = "tb_email";
            tb_email.PlaceholderText = "E-mail do usuário";
            tb_email.Size = new Size(206, 30);
            tb_email.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(93, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(593, 335);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fechar_programa).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox tb_senha;
        private TextBox tb_email;
        private Button bt_login;
        private Label label1;
        private PictureBox fechar_programa;
    }
}
