using Maquina_de_Cafe_Virtual.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_de_Cafe_Virtual.Controle
{
    class Logica
    {
        public string mensagemErro = "";
        double ValorSomado = 0;
        public List<Moedas> RecebeMoeda(Moedas entradaListaDeMoedas)
        {
            List<Moedas> listaMoedas = new List<Moedas>();
            try
            {
                if(entradaListaDeMoedas.valorMoeda == 0)
                {
                    listaMoedas.Clear();
                }
                else
                {
                    listaMoedas.Add(new Moedas(entradaListaDeMoedas.nomeMoeda, entradaListaDeMoedas.valorMoeda));
                }
            }
            catch (Exception e)
            {
                this.mensagemErro = "Error" + e.Message;
            }
            return listaMoedas;
        }

        public string AtualizaValorCreditado(Moedas entradaDeMoedas)
        {
            if (entradaDeMoedas.valorMoeda == 0)
            {
                ValorSomado = 0;
            }
            else
            {
                ValorSomado += entradaDeMoedas.valorMoeda;
                RecebeMoeda(entradaDeMoedas);
            }
            return ValorSomado.ToString();
        }

        public List<Produtos> RecebeProduto(Produtos entradaProdutos)
        {
            List<Produtos> listaProdutos = new List<Produtos>();
            try
            {
                listaProdutos.Add(new Produtos(entradaProdutos.nomeProduto, entradaProdutos.valorProduto));
            }
            catch (Exception e)
            {
                this.mensagemErro = "Error" + e.Message;
            }
            return listaProdutos;
        }

        public double[] RecebeValorOpçãoDeProduto()
        {
            double[] ativarProduto = new double[3];
            if (ValorSomado >= 3 && ValorSomado < 3.5)
            {
                ativarProduto[0] = 1;

            }
            else if(ValorSomado>= 3.5 && ValorSomado < 4)
            {
                ativarProduto[1] = 2;
            }
            else if (ValorSomado >= 4)
            {
                ativarProduto[2] = 3;
            }
            return ativarProduto;
        }
    }
}
