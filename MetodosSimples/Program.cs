using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1° - Exercício
            /*Escreva um método que receba um número inteiro e rtetorne o seu
             dobro.*/
            Dobro dobrar1 = new Dobro();

            dobrar1.Dobrar();

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region 2 ° - Exercício
            /*Escreva um método que receba dois números inteiros e
             retorne a soma deles*/

            SomaDoisNumeros soma1 = new SomaDoisNumeros();

            soma1.Soma();

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region 3 ° - Exercício 
            /*Escreva um método que receba uma string e retorne a 
             quantidade caracteres dela.*/

            CaracteresString palavra1 = new CaracteresString();
            palavra1.Contar();


            Console.ReadKey();
            Console.Clear();
            #endregion

            #region 4 ° - Exercício
            /*Escreva um método que receba uma lista de números inteiros e retorne o
             maior valor da lista.*/

            MaiorValorLista lista1 = new MaiorValorLista();
            lista1.ValorLista();

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region 5° - Exercício
            /*Escreva um método que receba uma lista de strings e retorne a
             qauntidade de strings que possuem mais de 5 caracteres.*/

            MaisCinco registro1 = new MaisCinco();

            registro1.MaiorQueCinco();

            Console.ReadKey();

            #endregion
        }
    }
}
