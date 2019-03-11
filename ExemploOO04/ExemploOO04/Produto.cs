using System.Globalization;
namespace ExemploOO04
{
    class Produto
    {
        //atributos
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        //construtores
        public Produto() //construtor padrão
        { }

        public Produto(string nome, double preco, int quantidade)//construtor com 3 argumentos
        {
            _nome = nome;
            Preco = preco;
            Quantidade  = quantidade;
        }

        public Produto(string nome, double preco)//construtor com 2 argumentos
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 0;
        }
        //Properties
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        
        //funções ou  métodos
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}