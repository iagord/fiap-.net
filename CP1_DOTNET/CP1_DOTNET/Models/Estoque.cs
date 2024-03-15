using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP1_DOTNET.Models
{
    public class Estoque
    {
        public List<Medicamento> Medicamentos { get; set; }

    
        public Estoque()
        {
            Medicamentos = new List<Medicamento>();
        }
        
        //metodo public
        public Estoque(List<Medicamento> medicamentos)
        {
            Medicamentos = medicamentos;

        }

}
}
