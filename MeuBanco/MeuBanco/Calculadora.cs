using System;
using System.Collections.Generic;
using System.Text;

namespace MeuBanco
{
    // Essa classe é estática, isso significa que podemos acessar seus membros sem instanciar um objeto dessa classe
    static class Calculadora
    {
        public static double somar(double valorA, double valorB)
        {
            return valorA + valorB;
        }
    }
}
