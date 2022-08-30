using System;
using System.Collections.Generic;
using System.Text;

namespace MeuBanco
{
    //Declarando uma classe pública e abstrata, ou seja, não será possível instanciar um objeto desta classe
    public abstract class Pessoa
    {
        //Tornando as variáveis acessíveis através do método public, assim é possível modificá-las em outra classe.
        //Podemos modificar as propriedades através do { get; set; }
        //Não é necessário criar a variável privada, pois quando criamos com letra maiúscula a propriedade e colocamos o get e set, é criado por "debaixo dos panos" a variável privada
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        private string nome;
        //Implementação manual do GET e SET via propriedade Nome, o nome é dado devido ao get e set
        public string Nome {
            get { 
                return this.nome;
            }
            set {
                this.nome = value;
            }
        }

        public int idade { get; set; }

        //
        public Pessoa() { }

        //Definição de um método construtor
        public Pessoa(string nome, string telefone, string endereco)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Endereco = endereco;
            idade = 0;
        }

        //Controlando o nível de acesso à variável nome
        //public string Nome()
        //{
        //    return nome;
        //}

        //public void Nome(string nome)
        //{
        //    this.nome = nome;
        //}

        // Declarando um método sem retorno
        public void Imprimir()
        {
            // cw 2x tab snippet para o comando Console.WriteLine()
            Console.WriteLine("Nome: " + nome + ", Telefone: " + Telefone + ", Endereço: " + Endereco + ", Idade: " + idade);
        }
    }
}
