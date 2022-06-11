namespace Exercicio___Dados_do_Produto.Entities
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            Nome=nome;
            Preco=preco;
        }

        public virtual string PriceTag()
        {
            return Nome + " $ " + Preco;
        }

        public virtual double PrecoTotal()
        {
            return Preco;
        }
    }
}
