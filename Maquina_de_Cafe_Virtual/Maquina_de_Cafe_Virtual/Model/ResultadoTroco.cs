using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_de_Cafe_Virtual.Model
{
    class ResultadoTroco
    {
        public int moedaValor;
        public int quantidadeMoeda;

        public ResultadoTroco(int moedaValor, int quantidadeMoeda)
        {
            this.moedaValor = moedaValor;
            this.quantidadeMoeda = quantidadeMoeda;
        }
    }
}
