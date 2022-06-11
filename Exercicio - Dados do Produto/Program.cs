using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio___Dados_do_Produto.Entities;

namespace Exercicio___Dados_do_Produto
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            List<Produto> list = new List<Produto>();

            Console.Write("Digite a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("PRODUTO #" + i);                
                Console.Write("Comum, usado ou importado (c/u/i)? ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (tipo == 'u')
                {
                    Console.Write("Data de Fabricação (DD/MM/YYYY): ");
                    DateTime dataproduto = DateTime.Parse(Console.ReadLine());
                    list.Add(new ProdutoUsado(nome, preco, dataproduto));

                }
                else if(tipo == 'i')
                {
                    Console.Write("Taxa de imposto: ");
                    double taxaproduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ProdutoImportado(nome, preco, taxaproduto));
                }
                else
                {
                    list.Add(new Produto(nome, preco));

                }
            }
            Console.WriteLine("TABELA DE PREÇOS:");
            foreach(Produto emp in list)
            {
                Console.WriteLine(emp.PriceTag());
            }                       
        }
    }
}
