using System;
using System.Collections.Generic;

namespace Prova1
{
    internal class Program
    {
 

        static void Main(string[] args)
        {

            int numVendas = 0, numeroDeVendas = 1;
            bool resposta = false;
            List<Produtos> produtos = Produtos.InitializateProdutos();
            List<Funcionario> funcionarios = Funcionario.InitializeFuncionario();
            List<Vendas> vendas = new List<Vendas>();
            int totalItens = Produtos.TotalItens(produtos);

            Console.WriteLine("----- L&L Doces Artesanais -----");
            Console.WriteLine("Produtos em estoque: " + totalItens);
            Console.Write("Digite a quantidade de vendas a ser realizada: ");
            numVendas = int.Parse(Console.ReadLine());

            if (numVendas > totalItens)
            {
                Console.WriteLine("A quantidade da sua compra é maior que o estoque atual!");
            }
            else {
                Console.WriteLine("\nLista de funcionários: ");

                foreach (Funcionario funcionario in funcionarios)
                {
                    Console.WriteLine(funcionario.ToString());
                }
                Console.Write("\nCódigo do Funcionário: ");
                int idFuncionario = int.Parse(Console.ReadLine());

                Console.WriteLine("\nLista de Produtos em Estoque: ");
                foreach (Produtos produto in produtos)
                {
                    Console.WriteLine(produto.ToString());
                }
                Console.Write("\nDigite o id do produto: ");
                int idProduto = int.Parse(Console.ReadLine());
                if (idProduto == 001 && produtos[0].Estoque > 0) {
                    Console.WriteLine($"O produto selecionado foi {produtos[0].Nome} no valor de : {produtos[0].Valor} reais");
                }
                else if (idProduto == 002 && produtos[1].Estoque > 0)
                {
                    Console.WriteLine($"O produto selecionado foi {produtos[1].Nome} no valor de : {produtos[1].Valor} reais");
                }
                else if (idProduto == 003 && produtos[2].Estoque > 0)
                {
                    Console.WriteLine($"O produto selecionado foi {produtos[2].Nome} no valor de : {produtos[2].Valor} reais");
                }
                else {
                    Console.WriteLine("Não existe este produto!");
                }

            }
           


        }
    }
}
