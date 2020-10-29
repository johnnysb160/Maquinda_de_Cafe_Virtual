﻿using Maquina_de_Cafe_Virtual.Model;
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
                if (entradaListaDeMoedas.valorMoeda == 0)
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


        public List<ResultadoTroco> CalculaTroco(Produtos entradaProdutos)
        {
            List<ResultadoTroco> ListaResultado = new List<ResultadoTroco>();
            int[] moedasInteirasCedulas = { 100, 50, 20, 10, 5, 2, 1 };
            int[] moedasFracionadas = { 50, 25, 10, 5, 1 };
            double trocoProduto;
            int i, valorAux, contadorMoedas;
            trocoProduto = ValorSomado - entradaProdutos.valorProduto;

            // definindo as notas do troco (parte inteira)
            valorAux = (int)trocoProduto;
            i = 0; while (valorAux != 0)
            {
                contadorMoedas = valorAux / moedasInteirasCedulas[i];
                if (contadorMoedas != 0)
                {
                    ListaResultado.Add(new ResultadoTroco(moedasInteirasCedulas[i], contadorMoedas));
                    valorAux = valorAux % moedasInteirasCedulas[i];
                }
                i = i + 1;
            }
            valorAux = (int)Math.Round((trocoProduto - (int)trocoProduto) * 100);
            i = 0;
            while (valorAux != 0)
            {
                contadorMoedas = valorAux / moedasFracionadas[i];
                if (contadorMoedas != 0)
                {
                    ListaResultado.Add(new ResultadoTroco(moedasFracionadas[i], contadorMoedas));
                    valorAux = valorAux % moedasFracionadas[i];
                }
                i = i + 1;
            }
            return ListaResultado;
        }


        public string AtualizaValorCreditado(Moedas entradaDeMoedas)
        {
            if (entradaDeMoedas.valorMoeda == 0)
            {
                ValorSomado = 0;
            }
            else if ((ValorSomado + entradaDeMoedas.valorMoeda) <= 4.50)
            {
                ValorSomado += entradaDeMoedas.valorMoeda;
                RecebeMoeda(entradaDeMoedas);
            }
            return ValorSomado.ToString("C2");
        }

        public double[] RecebeValorOpçãoDeProduto()
        {
            double[] ativarProduto = new double[3];
            if (ValorSomado >= 3 && ValorSomado < 3.5)
            {
                ativarProduto[0] = 1;

            }
            else if (ValorSomado >= 3.5 && ValorSomado < 4)
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
