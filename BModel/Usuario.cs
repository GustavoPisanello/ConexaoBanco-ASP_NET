using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoDb
{
    public class Usuario
    {
        public int IdUsu { get; set;}  
        public string Nome { get; set;}
        public string Cargo { get; set; }
        public DateTime DataNasc { get; set;  }
    }
}
