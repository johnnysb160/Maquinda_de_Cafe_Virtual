using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_de_Cafe_Virtual.Model
{
    class Moedas
    {
        public string nomeMoeda;
        public double valorMoeda;

        public Moedas(string nomeMoeda, double valorMoeda)
        {
            this.nomeMoeda = nomeMoeda;
            this.valorMoeda = valorMoeda;
        }
    }
}
