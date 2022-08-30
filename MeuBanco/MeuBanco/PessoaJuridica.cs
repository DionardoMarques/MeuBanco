using System;
using System.Collections.Generic;
using System.Text;

namespace MeuBanco
{
    class PessoaJuridica : Pessoa
    {
        public int Cnpj { get; set; }
        public string RazaoSocial { get; set; }

        public PessoaJuridica()
        {
        }

        public PessoaJuridica(int cnpj, string razaoSocial)
        {
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
        }

        public void imprimir()
        {
            base.Imprimir();
            Console.WriteLine("CNPJ: " + Cnpj);
            Console.WriteLine("Razão social: " + RazaoSocial);
        }
    }
}
