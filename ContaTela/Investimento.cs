using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaTela
{
    internal class Investimento : Conta
    {
        public double limite { get; set; }
      
        public double sacar()
        {
            if(saldo <  limite)
            {
                saldo -= limite;
            }
            return saldo;
        }
    }
}
