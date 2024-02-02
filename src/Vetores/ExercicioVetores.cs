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
            Validacao.AguardarTecla();
        }

        /* 05 - Criar uma programa que copie o conteúdo de um vetor em um segundo vetor. A programa deve retornar o vetor copiado.  */
        public static void Ex05()
        {
            Console.WriteLine("Informe 5 números: ");

            double[] vetor = new double[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Informe o valor {i + 1}: ");
                if (double.TryParse(Console.ReadLine(), out double valor))
                {
                    vetor[i] = valor;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
                    i--; // Decrementa o índice para repetir a entrada para o mesmo elemento do array
                }
            }

            double[] vetorCopiado = vetor;

            for (int i = 0; i < vetorCopiado.Length; i++)
            {
                Console.WriteLine($"Vetor copiado: [{vetorCopiado[i]}]");
            }
            Validacao.AguardarTecla();
        }

        /* 06- Criar uma programa que some o conteúdo de dois vetores e armazene o resultado em um terceiro vetor. A programa deve retornar o terceiro vetor. */
        public static void Ex06()
        {
            Console.WriteLine("Informe 3 valores para o vetor A e vetor B.");

            // Vetor A
            int[] vetorA = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Informe o {i + 1}º valor do vetor A: ");
                if (int.TryParse(Console.ReadLine(), out int valor))
                {
                    vetorA[i] = valor;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
                    i--; // Decrementa o índice para repetir a entrada para o mesmo elemento do array
                }
            }

            Console.WriteLine();

            // Vetor B
            int[] vetorB = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Informe o {i + 1}º valor do vetor B: ");
                if (int.TryParse(Console.ReadLine(), out int valor))
                {
                    vetorB[i] = valor;
                }
            }

            // Soma dos vetores A e B
            int[] vetorSoma = new int[3];
            for (int i = 0; i < 3; i++)
            {
                vetorSoma[i] = vetorA[i] + vetorB[i];
            }

            // Exibindo o vetor resultante
            Console.WriteLine("\nVetor resultante (soma de A e B):");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{vetorSoma[i]} ");
            }

            Validacao.AguardarTecla();
        }

        /* 07 - Criar um programa que leia um vetor de 10 elementos de inteiro e apresente a soma dos valores que estão nos índices pares do vetor. */
        public static void Ex07()
        {
            int[] vetorElementos = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Informe o {i + 1} º valor do vetor: ");
                if (int.TryParse(Console.ReadLine(), out int valor))
                {
                    vetorElementos[i] = valor;
                }
            }

            int somaPares = 0;

            for (int i = 0; i < vetorElementos.Length; i += 2)
            {
                somaPares += vetorElementos[i];
            }
            Console.WriteLine($"A soma dos valores nos índices pares do vetor é: {somaPares}.");
             Validacao.AguardarTecla();
        }

        /* 08 Criar um programa que leia um vetor de 16 posições de valores inteiros e troque os 8 primeiros valores pelos 8 últimos valores e vice-versa. Ao final apresentar na tela os dados do vetor obtido. */
        public static void Ex08()
        {
            int[] vetorPosicao = new int[16];
            for (int i = 0; i < 16; i++)
            {
                Console.Write($"Informe o {i + 1} º valor do vetor: ");
                if (int.TryParse(Console.ReadLine(), out int valor))
                {
                    vetorPosicao[i] = valor;
                }
            }


            for (int i = 0; i < 8; i++)
            {
                // Armazena temporariamente o valor dos primeiros 8 elementos do vetor
                int temp = vetorPosicao[i]; // ler os 8 primeiros

                // Atribui o valor dos últimos 8 elementos do vetor aos primeiros 8 elementos
                vetorPosicao[i] = vetorPosicao[i + 8];

                // Atribui o valor temporariamente armazenado (dos primeiros 8 elementos) aos últimos 8 elementos
                vetorPosicao[i + 8] = temp;
            }

            Console.WriteLine("Vetor obtido após a troca:");
            for (int i = 0; i < 16; i++)
            {
                Console.Write($"{vetorPosicao[i]} ");
            }

        }

        /*09 - Criar um programa que leia dois vetores de 4 posições de valores inteiros. 
        Criar outro vetor preenchendo-o nas posições pares com os valores do primeiro vetor e nas posições ímpares com os valores do segundo vetor. Apresentar na tela os dados do vetor criado.*/
        public static void Ex09()
        {
            int[] primeiroVetor = new int[4]; // valores pares
            int[] segundoVetor = new int[4]; // valores impares

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Informe o {i + 1} º valor do primeiro vetor: ");
                if (int.TryParse(Console.ReadLine(), out int valor))
                {
                    primeiroVetor[i] = valor;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Informe o {i + 1} º valor do segundo vetor: ");
                if (int.TryParse(Console.ReadLine(), out int valor))
                {
                    segundoVetor[i] = valor;
                }
            }

            int[] vetorElementos = new int[8]; // 1 posição = impar // 2 posição = par

            for (int i = 0; i < 4; i++)
            {
                // posição pares
                vetorElementos[i * 2] = primeiroVetor[i];

                // posição impar
                vetorElementos[i * 2 + 1] = segundoVetor[i];
            }
            Console.WriteLine("Vetor criado com valores intercalados:");
            foreach (var elemento in vetorElementos)
            {
                Console.Write(elemento + " ");
            }
             Validacao.AguardarTecla();
        }
    
        /*10Criar um programa que leia uma determinada quantia a ser retirada em um caixa eletrônico e apresente a quantidade mínima de cédulas equivalente. 
        As cédulas são de 50, 20 e 10. Utilizar sempre que possível cédulas de maior valor. O valor da quantia a ser retirada deve ser múltiplo de 10. 
        Guardar em um vetor a quantidade de cada cédula. Apresentar os dados do vetor de cédulas na tela.*/
        public static void Ex10()
        {
            Console.Write("Informe a quantia a ser retirada (múltiplo de 10): ");
            if (int.TryParse(Console.ReadLine(), out int quantia) && quantia % 10 == 0)
            {
                // Definindo os valores das cédulas
                int[] valoresCedulas = { 50, 20, 10 };

                // Vetor para armazenar a quantidade de cada cédula
                int[] quantidadeCedulas = new int[valoresCedulas.Length];

                // Calculando a quantidade de cada cédula
                for (int i = 0; i < valoresCedulas.Length; i++)
                {
                    quantidadeCedulas[i] = quantia / valoresCedulas[i];
                    quantia %= valoresCedulas[i];
                }

                // Apresentando os dados do vetor de cédulas
                Console.WriteLine("\nQuantidade de cédulas:");

                for (int i = 0; i < valoresCedulas.Length; i++)
                {
                    Console.WriteLine($"{valoresCedulas[i]} reais: {quantidadeCedulas[i]} cédulas");
                }
            }
            else
            {
                Console.WriteLine("A quantia informada não é um múltiplo de 10.");
            }
             Validacao.AguardarTecla();
        }

                /* 11 Criar um programa que leia um vetor de 10 posições de valores inteiros e decomponha-o em dois outros vetores de 5 posições, um contendo os elementos das posições ímpares e o outro contendo os elementos das posições pares. 
        Por exemplo, se o vetor dado for v = {1, 5, 4, 7, 2, 8, 10, 11, 13, 16} o programa deve gerar os vetores u = {1, 4, 2, 10, 13} e w = {5, 7, 8, 11, 16}. 
        Apresentar os valores dos vetores gerados na tela. */
        public static void Ex11()
        {
            int[] vetorOriginal = new int[10];
            int[] vetorPosicoesPares = new int[5];
            int[] vetorPosicoesImpares = new int[5];

            // Preencher o vetorOriginal
            Console.WriteLine("Informe 10 valores inteiros para preencher o vetor:");
            for (int i = 0; i < vetorOriginal.Length; i++)
            {
                Console.Write($"Informe o {i + 1}º valor: ");
                if (int.TryParse(Console.ReadLine(), out int valor))
                {
                    vetorOriginal[i] = valor;
                }
            }

            // Decompor o vetorOriginal em vetorPosicoesPares e vetorPosicoesImpares
            int indicePares = 0;
            int indiceImpares = 0;

            for (int i = 0; i < vetorOriginal.Length; i++)
            {
                if (i % 2 == 0)
                {
                    vetorPosicoesPares[indicePares] = vetorOriginal[i];
                    indicePares++;
                }
                else
                {
                    vetorPosicoesImpares[indiceImpares] = vetorOriginal[i];
                    indiceImpares++;
                }
            }

            // Exibir os valores dos vetores gerados
            Console.WriteLine("\nValores do vetor de posições pares (u):");
            foreach (var valor in vetorPosicoesPares)
            {
                Console.Write(valor + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nValores do vetor de posições ímpares (w):");
            foreach (var valor in vetorPosicoesImpares)
            {
                Console.Write(valor + " ");
            }
            Console.WriteLine();
             Validacao.AguardarTecla();
        }
    
    }
}


