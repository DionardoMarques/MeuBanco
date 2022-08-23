using System;

namespace MeuBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando e instanciando um objeto
            Pessoa p1 = new Pessoa();
            p1.Nome = "Ana";
            p1.telefone = "(51) 9-9823-4721";
            p1.endereco = "Av. Baltazar, 821";

            Pessoa p2 = new Pessoa();
            p2.Nome = "Joaquim";
            p2.telefone = "(11) 9-8230-0532";
            p2.endereco = "Rua Salazar, 1540";

            Conta c1 = new Conta();
            c1.numero = 06780291;
            c1.agencia = 3012;
            c1.titular = p1;
            //Utiliza o método Depositar que está dentro da classe Conta.cs para inserir saldo (variável privada) a uma conta
            c1.Depositar(12500);

            Conta c2 = new Conta();
            c2.numero = 02150273;
            c2.agencia = 3012;
            c2.titular = p2;
            c2.Depositar(0);

            c2.Imprimir();
            //Transfere 500 da Ana para o Joaquim
            c1.Transferir(500, c2);
            //Mostrar dados da Ana
            c1.Imprimir();
            //Mostrar dados do Joaquim
            c2.Imprimir();

            //Chamando o método Imprimir da classe Conta que printa os dados do titular e da conta.
            //c1.Imprimir();

            //c1.Depositar(500);

            //c1.Imprimir();

            //if (c1.Sacar(2000)) {
            //    Console.WriteLine("Saque efetuado com sucesso!");
            //}else
            //{
            //    Console.WriteLine("Saldo insuficiente!");
            //};

            //c1.Imprimir();
        }
    }
}
