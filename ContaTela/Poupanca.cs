using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaTela
{
    internal class Poupanca : Conta
    {
        public int dia { get; set; }
       public double rendimento { get; set; }
        public double getSaldo()
        {
            return saldo;
        }
        public double novoSaldo()
        {
            rendimento = 0.1;
            return (rendimento * saldo) + saldo;
        }
        
      
    }
}
