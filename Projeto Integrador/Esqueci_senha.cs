using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_Integrador
{
    public partial class Esqueci_senha : Form
    {
        public Esqueci_senha()
        {
            InitializeComponent();
        }


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

        private void Esqueci_senha_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 30, 30));
            tb_email.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tb_email.Width, tb_email.Height, 30, 30));
            tb_cpf.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tb_cpf.Width, tb_cpf.Height, 30, 30));
            bt_verificar.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, bt_verificar.Width, bt_verificar.Height, 30, 30));
            tb_senha.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tb_senha.Width, tb_senha.Height, 30, 30));
        }

        private void fechar_programa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
