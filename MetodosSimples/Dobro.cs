using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosSimples
{
    internal class Dobro
    {
        public double num1;
        public double total;

        public void Dobrar()
        {
            Console.WriteLine("Digite um número: ");
            num1 = double.Parse(Console.ReadLine());

            total = num1 * 2;

            Console.WriteLine("O dobro de " + num1 + " = " + total);
        }
    }
}
