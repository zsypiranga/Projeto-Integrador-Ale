using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Data.SqlClient;
using Sistema_de_Agendamento___Professor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_Integrador

{
    public partial class Form1 : Form
    {

        public static string adm { get; set; }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );


        public Form1()
        {
            InitializeComponent();
        }

        private void fechar_programa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

            panel2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 30, 30));
            tb_email.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tb_email.Width, tb_email.Height, 30, 30));
            tb_senha.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tb_email.Width, tb_email.Height, 30, 30));
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            bt_login.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tb_email.Width, tb_email.Height, 30, 30));
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            string senha = tb_senha.Text;
            string email = tb_email.Text;
            Connection cn = new Connection();
            string query = "select count(*) from tb_funcionarios where email = @email and senha = @senha";
            SqlCommand cmd = new SqlCommand(query, cn.conn);

            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);


            cn.Conectar(true);
            int reg = (int)cmd.ExecuteScalar();
            if (reg > 0)
            {
                query = $"select * from tb_funcionarios where email = '{email}' and senha = '{senha}' and nivel_funcionario !='{adm}'";
                cmd = new SqlCommand(query, cn.conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {


                    // id_funcionario = int.Parse(reader["id_funcionario"].ToString());
                    //  nomeUsuario = reader["nome_funcionario"].ToString();
                    email = reader["email"].ToString();
                    senha = reader["senha"].ToString();
                    adm = reader["nivel_funcionario"].ToString();
                    //user = reader["nivel_func"].ToString();



                }
                if (adm == "admin")
                {
                    MenuAdmin Admin = new MenuAdmin();//para abrir o novo formulario Comentario
                    Admin.Show();
                }
                else
                {
                    MenuUser User = new MenuUser();
                    User.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuário não encontrado");
            }
            cn.Conectar(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Esqueci_senha esqueci = new Esqueci_senha();
            esqueci.Show();
        }
    }
}
