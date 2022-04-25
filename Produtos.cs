using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    internal class Produtos
    {
        public int Codigo { get; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Estoque { get;  set; }
        


        public Produtos(int codigo, string nome, double valor, int estoque)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Valor = valor;
            this.Estoque = estoque;
          
        }

        public override string ToString()
        {
            return "Codigo: " + Codigo.ToString("000") + ", Produtos: " + Nome + ", Valor: R$ "
                + Valor + ", Disponível: " + Estoque;
        }
        public static int TotalItens(List<Produtos> produtos)
        {
            int estoqueTotal = 0;

            foreach (Produtos produto in produtos)
            {
                estoqueTotal += produto.Estoque;
            }
            return estoqueTotal;
        }


        public static List<Produtos> InitializateProdutos()
        {
            List<Produtos> produtos = new List<Produtos>();

            produtos.Add(new Produtos(001, "Barra de Chocolate", 35.00, 20));
            produtos.Add(new Produtos(002, "Bolo", 50.00, 8));
            produtos.Add(new Produtos(003, "Caixa de brigadeiro", 20.00, 10));

            return produtos;

        }
    }
}
