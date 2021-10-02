using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Produto.model
{
    public class Products
    {
        private int id;
        private String nome;
        private double valor;

        public Products()
        {
        }

        public Products(int id, string nome, double valor)
        {
            this.Id = id;
            this.Nome = nome;
            this.Valor = valor;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public double Valor { get => valor; set => valor = value; }
    }
}