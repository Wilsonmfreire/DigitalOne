using System;

namespace DIO.BANCK
{
    public class Conta
    {
        private TipoConta TipoConta {get; set; }
        private double Saldo {get; set; }
        private double Credito {get; set; }
        private string Nome {get; set; }
        
        public Conta(TipoConta tipoConta, double Saldo, double Credito, string Nome )
        {
            this.TipoConta = tipoConta;
            this.Saldo = Saldo;
            this.Credito = Credito;
            this.Nome = Nome;
        }

        public bool Sacar(double valorSaque)
        {
            if (this.Saldo - valorSaque<this.Credito *-1)
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            this.Saldo -= valorSaque;

            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);

            return true;
        }

        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
        }

        public void Transferir(double ValorTransferencia, Conta contaDestino)
        {
            if(this.Sacar(ValorTransferencia))
            {
                contaDestino.Depositar(ValorTransferencia);
            }
        }

        public override string ToString()
        {
            string retorno = " ";
            retorno += "Tipo Conta " + this.TipoConta + " | ";
            retorno +="Nome " + this.Nome + " | ";
            retorno +="Saldo " + this.Saldo + " | ";
            retorno +="Crédito " + this.Credito;
            return retorno;
        }
   }
}