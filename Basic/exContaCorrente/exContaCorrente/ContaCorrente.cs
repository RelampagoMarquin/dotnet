using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace exContaCorrente
{
    public class ContaCorrente
    {
        public float saldo;
        public int numero;
        public string cliente;

        public ContaCorrente(string cliente)
        {
            this.saldo = 0;
            this.numero = 1;
            this.cliente = cliente;
        }

        public ContaCorrente(float saldo, string cliente)
        {
            this.saldo = saldo;
            this.numero = 1;
            this.cliente = cliente;
        }

        public void depositar(float value){
            this.saldo -= value;
        }

        public void sacar(float value) {  
            this.saldo += value; 
        }

        public float consultarSaldo() { 
            return this.saldo; 
        }
    }
}
