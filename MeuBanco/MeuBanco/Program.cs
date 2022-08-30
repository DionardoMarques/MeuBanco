using System;

namespace MeuBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando e instanciando um objeto
            PessoaFisica p1 = new PessoaFisica()
            {
                Nome = "Ana",
                Telefone = "(51) 9-9823-4721",
                Endereco = "Av. Baltazar, 821",
                Rg = 2103920,
                Cpf = 029387
            };
            
            PessoaFisica p2 = new PessoaFisica();
            p2.Nome = "Joaquim";
            p2.Telefone = "(11) 9-8230-0532";
            p2.Endereco = "Rua Salazar, 1540";
            p2.idade = 39;
            p2.Cpf = 859209902;
            p2.Rg = 1094283901;

            Conta c1 = new Conta()
            {
                Agencia = 3482,
                Numero = 12345678,
                Titular = p1
            };
            c1.Numero = 06780291;
            c1.Agencia = 3012;
            c1.Titular = p1;
            //Utiliza o método Depositar que está dentro da classe Conta.cs para inserir saldo (variável privada) a uma conta
            c1.Depositar(12500);

            Conta c2 = new Conta();
            c2.Numero = 02150273;
            c2.Agencia = 3012;
            c2.Titular = p2;
            c2.Depositar(0);

            c2.Imprimir();
            //Transfere 500 da Ana para o Joaquim
            c1.Transferir(500, c2);
            //Mostrar dados da Ana
            c1.Imprimir();
            p1.Imprimir();
            //Mostrar dados do Joaquim
            c2.Imprimir();
            p2.Imprimir();

            PessoaJuridica pj = new PessoaJuridica()
            {
                Telefone = "9529052183",
                Endereco = "Av.Flores, 721",
                Nome = "Dolphin Eirelli",
                Cnpj = 2413892,
                RazaoSocial = "Dolphin Eletroinstalações"
            };

            Conta c3 = new Conta()
            {
                Agencia = 3482,
                Numero = 189013,
                Titular = pj
            };

            pj.Imprimir();
            c3.Imprimir();

            Console.WriteLine("Quantidade c1: " + Conta.Quantidade);

            Console.WriteLine("Soma 5 + 6" + Calculadora.somar(5, 6));

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
