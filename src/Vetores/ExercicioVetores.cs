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
            Validacao.AguardarTecla();
        }


        /* 02- Criar um programa que leia um vetor de 7 posições de valores inteiros, 
        conte quantos valores estão na faixa [10,20] e substitua os valores que estão nesta faixa pelo número 0 (zero).
         Apresentar na tela a quantidade de valores modificados e o vetor modificado. */

        public static void Ex02()
        {
            Console.WriteLine("Informe 7 números:");
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
            Validacao.AguardarTecla();
        }

        /* 03- Criar um programa que leia um vetor de 10 posições de valores inteiros e em seguida leia dois valores inteiros X e Y quaisquer correspondentes a duas posições no vetor. 
        Ao final apresentar na tela a soma dos valores encontrados nas posições X e Y. */
        public static void Ex03()
        {
            Console.WriteLine("Informe 10 números:");

            int[] arrayInteiros = new int[10];
            Random random = new Random(); // classe random

            for (int i = 0; i < 10; i++)
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

            // Escolher dois indices X e Y (aleatorios)
            int indice1 = random.Next(10);
            int indice2;

            // Garantir que os dois índices não são iguais
            do
            {
                indice2 = random.Next(10);
            }
            while (indice2 == indice1);

            //somar
            int soma = arrayInteiros[indice1] + arrayInteiros[indice2];
            Console.WriteLine($"Valores escolhidos aleatoriamente: {arrayInteiros[indice1]} e {arrayInteiros[indice2]}");
            Console.WriteLine($"A soma desses valores é: {soma}");
            Validacao.AguardarTecla();
        }


        /* 04 - Criar um programa que leia um vetor de 12 posições de valores inteiros e em seguida leia um valor inteiro X qualquer. 
        Fazer uma busca do valor de X no vetor lido e informar a posição em que foi encontrado ou se não foi encontrado. */
        public static void Ex04()
        {
            Console.WriteLine("Informe 12 números: ");
            int[] arrayInteiros = new int[12];

            for (int i = 0; i < 12; i++)
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


            Console.WriteLine("Informe um valor inteiro X qualquer: ");
            int valorX = int.Parse(Console.ReadLine());


            // Encontrar o valor
            List<int> posicoesEncontradas = new List<int>();

            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                if (arrayInteiros[i] == valorX)
                {
                    posicoesEncontradas.Add(i + 1);
                }
            }

            if (posicoesEncontradas.Count > 0)
            {
                // Utilizo o string.Join para concatenar as posições encontradas na lista posicoesEncontradas.
                // Isso me permite apresentar de maneira legível as diferentes posições onde o valor X foi encontrado,
                // utilizando uma vírgula e um espaço como separadores na mensagem de saída.
                Console.WriteLine($"O número {valorX} foi encontrado nas posições: {string.Join(", ", posicoesEncontradas)}");
            }
            else
            {
                Console.WriteLine($"O número {valorX} não foi encontrado no vetor.");
            }

        }

    }
}
