using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosSimples
{
    internal class MaisCinco
    {
        public int quantidade;
        public string palavras;
        public int quantidadePalavra;

        public void MaiorQueCinco()
        {
            quantidadePalavra = 0;
            Console.WriteLine("Quantas palavras deseja registrar ? ");
            quantidade = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < quantidade; i++)
            {
                Console.WriteLine("Digite uma palavra: ");
                palavras = Console.ReadLine();


                if(palavras.Length > 5)
                {
                    quantidadePalavra++;
                    
                }
            }
            Console.WriteLine("A quantidade de palavras com mais 5 caracteres são " + quantidadePalavra);
        }
    }
}
