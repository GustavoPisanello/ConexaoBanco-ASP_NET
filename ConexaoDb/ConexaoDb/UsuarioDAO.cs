using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoDb
{
    internal class UsuarioDAO
    {
        Banco db = new Banco();
        public void Insert(string strNomeUsu, string strCargo, string strDataNasc)
        {
            string strInsert = string.Format("Insert into tbUsuario(NomeUsu, Cargo,DataNasc)" +
               " values ('{0}', '{1}', STR_TO_DATE('{2}', '%d/%m/%Y'));", strNomeUsu, strCargo, strDataNasc);
            db.Open();
            db.ExecuteNowdSql(strInsert);
            db.Close();
        }

        public void Update(string strNomeUsu, string strCargo, string strDataNasc, string strIdUsu)
        {
            db.Open();
            // Update tbUsuario set NomeUsu = 'João' where IdUsu = 4;
            string strUpdate = string.Format("Update tbUsuario set NomeUsu = '{0}', Cargo = '{1}',DataNasc = STR_TO_DATE('{2}', '%d/%m/%Y %H:%i:%S') " + "where IdUsu = {3};", strNomeUsu, strCargo, strDataNasc, strIdUsu);
            
            db.ExecuteNowdSql(strUpdate);
            db.Close();
        }

        /*public void Delete( string strIdUsu)
        {
            string strDelete = string.Format("Delete from tbUsuario where IdUsu = {0};" + strIdUsu);
            db.Open();
            db.ExecuteNowdSql(strDelete);
            db.Close();
        }*/

        public string SelectDado(string strIdUsu)
        {
            string strDado = "select NomeUsu from tbUsuario where IdUsu = " + strIdUsu + ";";
            db.Open();
            strDado = db.ExecuteScalarSql(strDado);
            db.Close();
            return strDado;
        }

        public void Select()
        {
            string strSelect = "select * from tbUsuario;";
            db.Open();
            MySqlDataReader Leitor = db.ExecuteReaderSql(strSelect);
            while (Leitor.Read())
            {
                Console.WriteLine("Código: {0} | Nome: {1} | Cargo: {2} | Data de Nascimento: {3}",
                    Leitor["IdUsu"], Leitor["NomeUsu"], Leitor["Cargo"], Leitor["DataNasc"]);
            }
            Leitor.Close();

            db.Close();
           
        }
    }
}
