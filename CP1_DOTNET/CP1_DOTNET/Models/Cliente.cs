using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP1_DOTNET.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        // Construtor convencional
        public Cliente()
        {
        }

        // Construtor especializado
        public Cliente(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }

        // metodo privado
        private void ExibirDetalhesCliente()
        {
            Console.WriteLine($"Nome do Cliente: {Nome}");
            Console.WriteLine($"Endereço do Cliente: {Endereco}");
        }

    }
}
