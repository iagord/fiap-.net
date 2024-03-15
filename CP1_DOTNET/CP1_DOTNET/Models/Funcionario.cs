using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP1_DOTNET.Models
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }

   
        public Funcionario()
        {
        }

    
        public Funcionario(string nome, string cargo)
        {
            Nome = nome;
            Cargo = cargo;
        }

        //metodo internal
        internal void RegistroSaida()
        {
            Console.WriteLine($"Funcionário {Nome} registrou sua saída.");
        }

        public void RegistrarEntrada()
        {
            Console.WriteLine($"Funcionário {Nome} registrou sua entrada.");
            


        }
    }
}
