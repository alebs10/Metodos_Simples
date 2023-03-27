using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosSimples
{
    internal class MaiorValorLista
    {
        public int numero;
        public int tamanho;
        public int maior;

        public void ValorLista()
        {
            maior = 0;
            Console.WriteLine("Digite o tamanho da lista: ");
            tamanho = int.Parse(Console.ReadLine());

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Digite um número: ");
                numero = int.Parse(Console.ReadLine());

                if(numero > maior)
                {
                    maior = numero;
                }
            }

            Console.WriteLine("O maior número da lista: " + maior);
        } 
    }
}
