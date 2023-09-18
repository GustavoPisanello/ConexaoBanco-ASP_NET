using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;

namespace ConexaoDb
{
    public class Banco
    {
        private readonly MySqlConnection conexao = new MySqlConnection(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);
        private readonly MySqlCommand cmd = new MySqlCommand();
        
        public void Open()
        {
            if(conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
        }

        public void Close()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        public MySqlDataReader ExecuteReaderSql(string strQuery) {
            cmd.CommandText = strQuery;
            cmd.Connection = conexao;
            MySqlDataReader Leitor = cmd.ExecuteReader();
            return Leitor;
        }
        public void ExecuteNowdSql(string strQuery)
        {
            cmd.CommandText = strQuery;
            cmd.Connection = conexao;
            cmd.ExecuteNonQuery();
        }
        public string ExecuteScalarSql(string strQuery)
        {
            cmd.CommandText = strQuery;
            cmd.Connection = conexao;
            string strRetorno = Convert.ToString(cmd.ExecuteScalar());
            return strRetorno;
        }


    }
}
