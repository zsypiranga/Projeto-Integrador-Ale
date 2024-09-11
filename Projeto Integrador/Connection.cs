using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Agendamento___Professor
{
    internal class Connection
    {
        string server = @"VPR0687150W10-1\SQLEXPRESS";
        string db = "db_locadora_carros";
        string user = "sa";
        string pass = "123456";
        string connect;
        public SqlConnection conn;


        public Connection()
        {
            try
            {

                connect = $"Data Source = {server};Initial Catalog = {db};" +
                      $"User id = {user};Password = {pass};TrustServerCertificate=True";
                conn = new SqlConnection(connect);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
            }
        }

        public void Conectar(bool valor)
        {
            if (valor)
            {
                conn.Open();
            }
            else
            {
                conn.Close();
            }
        }
    }
}
