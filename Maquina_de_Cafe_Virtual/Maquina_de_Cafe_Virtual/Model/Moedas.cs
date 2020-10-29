using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_de_Cafe_Virtual.Model
{
    class Moedas
    {
        public enumMoedas valorMoeda;

        public Moedas(enumMoedas valorMoeda)
        {
            this.valorMoeda = valorMoeda;
        }
    }
    public enum enumMoedas : int
    {
        dezCentavos = 10,
        vinteCincoCentavos = 25,
        cinquinetaCentavos = 50,
         umReal = 100
    }
}
