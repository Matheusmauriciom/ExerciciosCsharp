using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExericioCsharp.src.Vetores
{
    public class ExercicioVetores
    {   /* 01- Criar um programa que leia 8 elementos inteiros em um vetor A. 
        Construir um vetor B do mesmo tipo e tamanho com os elementos do vetor A multiplicados por 3. 
        O elemento B[0] recebe o elemento A[0] * 3, o elemento B[1] recebe o elemento A[1] * 3 e assim por diante, até a posição 7 do vetor. Apresentar os elementos do vetor B. */
        public static void Ex01()
        {
            Console.WriteLine("Informe 8 números:");

            int[] arrayInteirosA = new int[8];

            // Loop para receber os valores e armazená-los no array
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"Informe o valor {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int valor))
                {
                    arrayInteirosA[i] = valor;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
                    i--; // Decrementa o índice para repetir a entrada para o mesmo elemento do array
                }
            }

            int[] arrayInteirosB = new int[8];

            // Loop para multiplicar os elementos de arrayInteirosA por 3 e armazenar em arrayInteirosB
            for (int i = 0; i < 8; i++)
            {
                arrayInteirosB[i] = arrayInteirosA[i] * 3;
            }
            // Exibe os elementos do arrayInteirosB
            Console.WriteLine("\nElementos do vetor B (elementos do vetor A multiplicados por 3):");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"Elemento B[{i + 1}]: {arrayInteirosB[i]}");

            }



        }


        /* 02- Criar um programa que leia um vetor de 7 posições de valores inteiros, 
        conte quantos valores estão na faixa [10,20] e substitua os valores que estão nesta faixa pelo número 0 (zero).
         Apresentar na tela a quantidade de valores modificados e o vetor modificado. */

        public static void Ex02()
        {
            int[] arrayInteiros = new int[7];

            // Loop para receber os valores e armazená-los no array
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Informe o valor {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int valor))
                {
                    arrayInteiros[i] = valor;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
                    i--; // Decrementa o índice para repetir a entrada para o mesmo elemento do array
                }
            }

            int valoresModificados = 0;
            // Loop para verificar e modificar os valores no intervalo [10, 20]
            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                if (arrayInteiros[i] >= 10 && arrayInteiros[i] <= 20)
                {
                    arrayInteiros[i] = 0;
                    valoresModificados++;
                }
            }
            // Apresentar na tela a quantidade de valores modificados
            Console.WriteLine($"Quantidade de valores modificados: {valoresModificados}");

            // Apresentar na tela o vetor modificado
            Console.Write("Vetor modificado: ");
            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                Console.Write($"{arrayInteiros[i]}");
                if (i < arrayInteiros.Length - 1)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}