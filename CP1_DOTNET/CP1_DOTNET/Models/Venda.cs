using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP1_DOTNET.Models
{
    public class Venda
    {
        public Cliente Cliente { get; set; }
        public List<Medicamento> ItensVendidos { get; set; }
        public decimal Total { get; set; }

      
        public Venda()
        {
            ItensVendidos = new List<Medicamento>();
        }

     
        public Venda(Cliente cliente, List<Medicamento> itensVendidos, decimal total)
        {
            Cliente = cliente;
            ItensVendidos = itensVendidos;
            Total = total;
        }
    }
}
