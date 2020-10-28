using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_de_Cafe_Virtual.Model
{
    class Produtos
    {
        public string nomeProduto;
        public double valorProduto;

        public Produtos(string nomeProduto, double valorProduto)
        {
            this.nomeProduto = nomeProduto;
            this.valorProduto = valorProduto;
        }
    }
}
