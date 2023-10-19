using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ContaTela
{
    internal class Conta
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public int id { get; set; } 
        public double saldo { get; set; }
        public string exibirDados()
        {

            return ($"Nome: {nome} \n CPF: {cpf} \n Número da conta: {id} \n Saldo: {saldo} \n Informe seu CPF para realizar operações");

        }


    }
}
