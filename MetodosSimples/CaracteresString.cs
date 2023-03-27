using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosSimples
{
    internal class CaracteresString
    {
        public string palavra;

        public void Contar()
        {
            Console.WriteLine("Digite uma palavra: ");
            palavra = Console.ReadLine();

            Console.WriteLine("A quantidade de caracteres de "+ palavra + " é " +palavra.Length);
        }
    }
}
