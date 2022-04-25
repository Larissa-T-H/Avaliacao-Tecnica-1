using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    internal class Vendas
    {
        public int NumVenda { get; set; }
        public Funcionario Funcionario { get; set; }
        public Produtos Produtos { get; set; }
        public double ValorTotal { get; set; }
        public int Qtd { get; set; }

        public Vendas(Funcionario funcionario, int numVenda, Produtos produtos, int qtd, double valorTotal)
        {
            this.Funcionario = funcionario;
            this.NumVenda = numVenda; 
            this.Produtos = produtos;
            this.Qtd = qtd;
            this.ValorTotal = valorTotal;
        }

        
    }
}
