using ConexaoDb;
using System;

namespace AppBanco
{
    internal class Program
    {
        static void Main(string[] args)
        { 
          
            UsuarioDAO usuDAO = new UsuarioDAO();
  
            Console.WriteLine("Informe o ID para identificação");
            string IdUsu = Console.ReadLine();
            string strDado = usuDAO.SelectDado(IdUsu);
            Console.WriteLine("Olá, Senhor(a) " + strDado);

            Console.WriteLine("Digite o Nome:");
            string strNomeUser = Console.ReadLine();

            Console.WriteLine("Digite o Cargo:");
            string strCargo = Console.ReadLine();

            Console.WriteLine("Informe a data de Nascimento");
            string strDataNasc = Console.ReadLine();

            usuDAO.Insert(strNomeUser, strCargo, strDataNasc);

            usuDAO.Select();

            Console.ReadLine();
        }
    }
}