namespace Exercicio___Dados_do_Produto.Entities
{
    internal class ProdutoImportado : Produto
    {
        public double TaxaProduto { get; set; }

        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string nome, double preco, double taxaproduto) : base(nome,preco)
        {
            TaxaProduto = taxaproduto;
        }

        public override double PrecoTotal()
        {
            return Preco + TaxaProduto;
        }

        public override string PriceTag()
        {
            return Nome +
               " $ " +
               PrecoTotal() +
               " (Valor de Taxação do Produto: " +
               TaxaProduto +
               ")";
        }
    }
}
