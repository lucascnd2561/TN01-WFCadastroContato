using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCadastroProduto
{
    class Produto
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Categoria { get; set; }
       
        public Double Preco { get; set; }
        public DateTime DataVencimento { get; set; }
        public string? Observacao { get; set; }



    }
}
