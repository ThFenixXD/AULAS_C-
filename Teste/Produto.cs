using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Teste
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto() { }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //public string GetNome()
        //{
        //    return _nome;
        //}

        //public void SetNome(string nome)
        //{
        //if (nome != null && nome.Length > 1)
        //{
        //    _nome = nome;
        //}
        //}

        //public double GetPreco()
        //{
        //    return _preco;
        //}

        //public int GetQuantidade()
        //{
        //    return _quantidade;
        //}

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        //public double Preco
        //{
        //    get { return _preco; }
        //}

        //public int Quantidade
        //{
        //    get { return _quantidade; }
        //}

        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
        }

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
                   + Quantidade.ToString("F2", CultureInfo.InvariantCulture)
                   + ", "
                   + Quantidade
                   + " unidade(s), Total: $ "
                   + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
            ;
        }
    }
}
