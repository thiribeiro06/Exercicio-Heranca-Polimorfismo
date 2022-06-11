using System;

namespace Exercicio___Dados_do_Produto.Entities
{
    internal class ProdutoUsado : Produto
    {
        public DateTime DataProduto { get; set; }

        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime dataProduto) : base(nome, preco)
        {
            DataProduto=dataProduto;
        }

        public override string PriceTag()
        {
            return Nome +
                " (usado) $ " +
                Preco +
                " (Data de fabricação: " +
                DataProduto +
                ")";
        }

        public override double PrecoTotal()
        {
            return base.PrecoTotal();
        }
    }
}
