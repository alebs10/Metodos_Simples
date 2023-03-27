using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosSimples
{
    internal class SomaDoisNumeros
    {
        public double num1;
        public double num2;
        public double soma;

        public void Soma()
        {
            Console.WriteLine("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            soma = num1 + num2;

            Console.WriteLine("A soma de " + num1 + " + " +  num2 + " = " + soma);
        }
    }
}
