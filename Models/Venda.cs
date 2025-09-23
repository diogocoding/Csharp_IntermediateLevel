using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace Csharp_IntermediateLevel.Models
{
    public class Venda
    {
        public Venda(int id, string produto, decimal preco)
        {
            this.Id = id;
            this.Preco = preco;
            this.produto = produto;
        }
        public int Id { get; set; }
        public string produto { get; set; }
        public decimal Preco { get; set; }
    }
}