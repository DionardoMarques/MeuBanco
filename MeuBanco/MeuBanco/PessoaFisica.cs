using System;
using System.Collections.Generic;
using System.Text;

namespace MeuBanco
{
    //Os : inidicam que essa classe estende * da classe Pessoa
    class PessoaFisica : Pessoa
    {
        public int Rg { get; set; }
        public int Cpf { get; set; }

        public void imprimir()
        {
            //Invoca o método da classe pai
            base.Imprimir();
            Console.WriteLine("RG: " + Rg);
            Console.WriteLine("CPF: " + Cpf);
        }
    }
}
