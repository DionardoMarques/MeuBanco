using System;
using System.Collections.Generic;
using System.Text;

namespace MeuBanco
{
    public class Conta
    {
        public int numero;
        public int agencia;
        private double saldo;
        //Declara uma variável do tipo Pessoa
        public Pessoa titular;

        public void Imprimir()
        {
            //Chama o método de Pessoa e printa os dados do titular
            titular.Imprimir();
            //Mostra os dados da conta
            Console.WriteLine("Número: " + numero + ", Agência: " + agencia + ", Saldo: " + saldo);
        }
        public void Depositar(double valor)
        {
            //saldo = saldo + valor;
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                //saldo = saldo - valor;
                saldo -= valor;
                return true;
            } else
            {
                return false;
            }
            
        }

        public void Transferir(double valor, Conta destino)
        {
            //if(saldo >= valor)
            //{
            //    saldo -= valor;
            //    destino.saldo += valor;
            //}
            if(this.Sacar(valor))
            {
                destino.Depositar(valor);
                Console.WriteLine("Transferência realizada com sucesso!");
            }
        }
    }
}
