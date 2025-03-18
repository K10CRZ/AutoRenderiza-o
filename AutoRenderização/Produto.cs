using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRenderização
{
    internal class Produto
    {
        private string Nome { get; set; }
        private double Valor { get; set;}
        private int Quantidade { get; set; }
        private string Descricao { get; set; }

        public Produto(string nome, double valor, int quantidade, string descricao)
        {
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
            Descricao = descricao;
        }
        public double CalcularEstoque()
        {
            return this.Valor * this.Quantidade;

        }

      
    }
}
