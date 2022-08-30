using System;
using System.Collections.Generic;
using System.Text;

namespace MeuBanco
{
    public class Conta
    {
        // Esta propriedade é estática tendo um comportamento de variável compartilhada (Global) com todos os objetos desta classe
        public static int Quantidade { get; set; }
        public int Numero { get; set; }
        public int Agencia { get; set; }
        private double saldo;
        //Declara uma variável do tipo Pessoa
        public Pessoa Titular { get; set; }

        public Conta() {
            this.saldo = 0;
            Quantidade++;
        }

        public Conta(int numero, int agencia, Pessoa titular) {
            this.Numero = numero;
            this.Agencia = agencia;
            this.Titular = titular;
            this.saldo = 0;
            Quantidade++;
        }

        public void Imprimir()
        {
            //Chama o método de Pessoa e printa os dados do titular
            //Titular.Imprimir();
            //Mostra os dados da conta
            Console.WriteLine("Número: " + Numero + ", Agência: " + Agencia + ", Saldo: " + saldo);
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
