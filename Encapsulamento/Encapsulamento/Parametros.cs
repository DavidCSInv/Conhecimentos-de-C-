// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Produto_Estoque
{
    class Produto
    {
        private string _nome; // Privou de conseguir verificar e chamar estas funções
        private double _preco; // Privou de conseguir verificar e chamar estas funções
        private int _quantidade; // Privou de conseguir verificar e chamar estas funções
        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            //fez um construtor com atributos privativos a sua tipagem é _nomedavariavel
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public string GetNome()
        {
            //metodo arcaico de volta de uma variavel atraves do metodo GET
            return _nome;
        }
        public void SetNome(string nome)
        {
            //Metodo manual para alteração atraves do SET 
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }
        public double GetPreco()
        {
            return _preco;
        }
        public int GetQuantidade()
        {
            return _quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

