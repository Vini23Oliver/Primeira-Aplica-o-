using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Bank
{
    class Conta
    {
        private TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private string Nome { get; set; }

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }

        public bool saque(double valorSaque) 
        {
            if (this.Saldo - valorSaque < (this.Credito * -1))
            {
                Console.WriteLine("Saldo insuficiente! ");
                return false;
            }
            else
            {
                this.Saldo = this.Saldo - valorSaque;
                return true;

                Console.WriteLine(" o saldo atual de conta de {0} é {1} ", this.Nome, this.Saldo);
            }
        }

        public void Depositar(double valorDeposito)
        {
            this.Saldo = this.Saldo + valorDeposito;
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
        }

        public void transferir(double valorTransferencia, Conta contaDestino) 
        {
            if (this.saque(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }

        }

        public override string ToString() // override = sobrescreve minha string
        {
            string retorno = "";
            retorno = retorno + "TipoConta: " + this.TipoConta + " | ";
            retorno = retorno + "Nome: " + this.Nome + " | ";
            retorno = retorno + "Saldo: " + this.Saldo + " | ";
            retorno = retorno + "Credito: " + this.Credito;
            return retorno;
        } 
    }
}
