using ConexaoDb;
using System;

namespace AppBanco
   
{
    internal class Program
    {
        static void Main(string[] args)
        { 
          
            UsuarioDAO usuDAO = new UsuarioDAO();
            Usuario usu = new Usuario();
  
            Console.WriteLine("Informe o ID para identificação");
            usu.IdUsu = int.Parse(Console.ReadLine());      
            usu.Nome = usuDAO.SelectDado(usu);  

            Console.Clear();

            Console.WriteLine("Olá, Senhor(a) " + usu.Nome);

            Console.WriteLine("\nVamos inserir um novo registro");
            Console.WriteLine("Digite o Nome:");
            usu.Nome = Console.ReadLine();

            Console.WriteLine("Digite o Cargo:");
            usu.Cargo = Console.ReadLine();

            Console.WriteLine("Informe a data de Nascimento");
            usu.DataNasc = DateTime.Parse(Console.ReadLine());

            usuDAO.Insert(usu);

            Console.WriteLine("\n");
            usuDAO.Select();

            Console.WriteLine("Digite o ID do resgistro a ser apagado: ");
            usu.IdUsu =int.Parse(Console.ReadLine());
            usuDAO.Delete(usu);

            Console.Clear();
            usuDAO.Select();

            Console.WriteLine("\n ");
            Console.WriteLine("Vamos atualizar um registro ");
            Console.WriteLine("\n ");
            Console.WriteLine("Digite o nome: ");
            usu.Nome = Console.ReadLine();

            Console.WriteLine("Digite o cargo: ");
            usu.Cargo = Console.ReadLine();

            Console.WriteLine("Informe a data de nascimento: ");
            usu.DataNasc = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Id: ");
            usu.IdUsu = int.Parse(Console.ReadLine());

            usuDAO.Update(usu);
            Console.ReadLine();

            Console.WriteLine("\n");
            usuDAO.Select();
        }
    }
}