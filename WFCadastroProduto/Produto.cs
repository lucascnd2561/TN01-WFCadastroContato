using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCadastroProduto
{
   public class Produto
    {
        public Produto(int codigo, string? nome, string? categoria, double preco, DateTime dataVencimento, string? observacao)
        {
            Codigo = codigo;
            Nome = nome;
            Categoria = categoria;
            Preco = preco;
            DataVencimento = dataVencimento;
            Observacao = observacao;
        }

        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Categoria { get; set; }
       
        public Double Preco { get; set; }
        public DateTime DataVencimento { get; set; }
        public string? Observacao { get; set; }

        public static List<Produto> Listaprodutos = new List<Produto>();

        public void Cadastrar()
        {
            Listaprodutos.Add(this);
        }
        
    }
}
