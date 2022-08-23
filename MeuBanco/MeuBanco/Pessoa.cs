using System;
using System.Collections.Generic;
using System.Text;

namespace MeuBanco
{
    //Declarando uma classe pública
    public class Pessoa
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
            Console.WriteLine("Nome: " + nome + ", Telefone: " + Telefone + ", Endereço: " + Endereco);
        }
    }
}
