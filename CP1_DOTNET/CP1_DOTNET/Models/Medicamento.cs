using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP1_DOTNET.Models
{
    public class Medicamento
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }

  
        public Medicamento()
        {
        }

      
        public Medicamento(string nome, string descricao, decimal preco, int quantidadeEmEstoque)
        {
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            QuantidadeEmEstoque = quantidadeEmEstoque;
        }

        //metodo protected
        protected void AtualizarEstoque(int quantidade)
        {
            QuantidadeEmEstoque += quantidade;
        }

    }
}
