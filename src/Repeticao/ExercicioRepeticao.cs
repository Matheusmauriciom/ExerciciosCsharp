using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ExericioCsharp.src.Repeticao
{
    public class ExercicioRepeticao
    {
        //01- Criar um algoritmo que apresente o quadrado dos números inteiros de 15 a 200.
        public static void Ex1()
        {

            for (int i = 15; i <= 200; i++)
            {
                Console.WriteLine($"O quadrado de {i} é {i * i}");
            }
            Validacao.AguardarTecla();
        }

        //02- Criar um algoritmo que apresente na tela os números de 1 a 50 em ordem decrescente.
        public static void Ex2()
        {
            for (int i = 50; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Validacao.AguardarTecla();
        }

        //03- Criar um algoritmo que calcule e apresente na tela a tabuada do 8 (1 a 10).
        public static void Ex3()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"8 x {i} = {i * 8}");
            }
            Validacao.AguardarTecla();
        }

        //04- Criar um algoritmo que leia um número inteiro positivo e apresente na tela a sua tabuada (1 a 10).
        public static void Ex4()
        {
            int numero = Validacao.ValidarNumero("Informe um número inteiro e positivo");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {i * numero}");
            }
            Validacao.AguardarTecla();
        }

        //05- Criar um algoritmo que apresente na tela o total da soma dos cem primeiros números inteiros positivos (1 + 2 + 3 + ... + 98 + 99 + 100).
        public static void Ex5()
        {
            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                soma += i;
                Console.WriteLine($"Soma após adicionar {i}: {soma}");
            }
            Validacao.AguardarTecla();
        }

        //06- Criar um algoritmo que apresente os valores da conversão de polegadas para centímetros, de 3 em 3, iniciando a contagem em 1 polegada e terminando em 13 polegadas. 
        //Uma polegada equivale a aproximadamente 2,54 centímetros.
        public static void Ex6()
        {
            double polegada = 2.54;

            for (int i = 1; i <= 13; i += 3)
            {
                double centimetros = polegada * i;
                Console.WriteLine($"Polegada {i}: {centimetros} cm");
            }
            Validacao.AguardarTecla();
        }

        //07- O número 3025 possui a seguinte característica: 30+25 = 55 e 55² = 3025. 
        //Criar um algoritmo que apresente na tela todos os números de quatro algarismos que possuem a característica citada.
        public static void Ex7()
        {
            for (int num = 1000; num <= 9999; num++)
            {
                int parte1 = num / 100; // Obtém os dois primeiros algarismos
                int parte2 = num % 100; // Obtém os dois últimos algarismos

                int soma = parte1 + parte2;
                int quadradoSoma = soma * soma;

                if (quadradoSoma == num)
                {
                    Console.WriteLine(num);
                }
            }
        }

        //08 Criar um algoritmo que leia um número inteiro e apresente na tela o seu fatorial. (Dica: 5! = 5x4x3x2x1 = 120).
        public static void Ex8()
        {
            int num = Validacao.ValidarNumero("Informe um número intero: ");
            int multi = 1;
            for (int i = num; i >= 1; i--)
            {
                multi = i * multi;
            }
            Console.WriteLine($"O fatorial de {num} é: {multi}");
            Validacao.AguardarTecla();
        }

        //09 Criar um algoritmo que leia um valor N e apresente na tela todos os valores inteiros entre 1 e N. Considere que o valor de N será sempre maior que zero.
        public static void Ex9()
        {
            int n = Validacao.ValidarNumero("Informe um número: ");

            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("O valor de N deve ser maior que zero.");
            }
            Validacao.AguardarTecla();
        }

        //10 Criar um algoritmo que efetue a leitura de 10 valores numéricos inteiros e, ao final, apresente na tela a soma e a média dos valores lidos.
        public static void Ex10()
        {
            int soma = 0;
            Console.WriteLine("Informe 10 valores inteiros: ");
            Console.WriteLine("");
            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine($"Informe o {i}º numero: ");
                int numero = int.Parse(Console.ReadLine());
                soma += numero;

            }
            double media = soma / 10;
            Console.WriteLine($"A soma dos valores é: {soma}");
            Console.WriteLine($"A média dos valores é: {media}");
            Validacao.AguardarTecla();
        }

        //11 - Criar um algoritmo que leia o número de horas trabalhadas diárias (NH) de um funcionário por um período de 20 dias (ele trabalhou todos os 20 dias) e apresente na tela o total de horas trabalhadas por ele nesse período.
        public static void Ex11()
        {
            int total = 0;
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"Informe a quantidade de horas trabalhadas no {i}º dia : ");
                int nh = int.Parse(Console.ReadLine());

                total += nh;
            }
            Console.WriteLine($"O total de horas trabalhadas em 20 dias, foi de {total} horas.");
            Validacao.AguardarTecla();
        }

        // 12 Um professor possui 3 turmas, e cada turma possui 5 alunos. Criar um algoritmo que leia a nota dos alunos de cada uma das turmas e apresente a média das notas por turma.
        public static void Ex12()
        {
            double mediaTurmaA = 0, mediaTurmaB = 0, mediaTurmaC = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Informe a nota do {i}º aluno da turma A: ");
                double notaA = double.Parse(Console.ReadLine());
                mediaTurmaA += notaA / 5;

            }
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Informe a nota do {i}º aluno da turma B: ");
                double notaB = double.Parse(Console.ReadLine());
                mediaTurmaB += notaB / 5;

            }
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Informe a nota do {i}º aluno da turma C: ");
                double notaC = double.Parse(Console.ReadLine());
                mediaTurmaC += notaC / 5;

            }

            Console.WriteLine($"Média da turma A: {mediaTurmaA}");
            Console.WriteLine($"Média da turma B: {mediaTurmaB}");
            Console.WriteLine($"Média da turma C: {mediaTurmaC}");
            Validacao.AguardarTecla();
        }

        //13 Criar um algoritmo que apresente na tela a tabuada dos números de 1 a 9.
        public static void Ex13()
        {
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"Tabuada do número {i}");
                Console.WriteLine("-------------------");
                for (int t = 1; t <= 10; t++)
                {
                    Console.WriteLine($"{i} x {t} = {i * t}");

                }
                Console.WriteLine("-------------------");
            }
        }

        //14 Criar um algoritmo que leia um número inteiro e repita a operação de multiplicar o número por 3 (apresentando o novo valor) até que o número seja maior que 100. 
        //Por exemplo, se o usuário informar 5, o algoritmo deve apresentar na tela a seguinte sequência: 5 15 45 135.
        public static void Ex14()
        {
            int num = Validacao.ValidarNumero("Informe um número intero: ");

            while (num <= 100)
            {
                num = num * 3;
                Console.Write($"{num}//");

            }
            Console.WriteLine();
        }

        // 15 O quadrado de um número natural N é dado pela soma dos N primeiros números ímpares consecutivos. 
        //Por exemplo 1² = 1,2² = 1 + 3,3²  etc. Criar um algoritmo que leia um número inteiro positivo maior que zero, calcule e apresente na tela seu quadrado usando a soma de ímpares ao invés de produto.
        public static void Ex15()
        {
            int numero = Validacao.ValidarNumero("Digite um número inteiro positivo maior que zero: ");

            if (numero > 0)
            {
                int quadrado = 0;
                int imparAtual = 1;

                for (int i = 0; i < numero; i++)
                {
                    quadrado += imparAtual;
                    imparAtual += 2;
                }
                Console.WriteLine($"O quadrado de {numero} usando a soma de ímpares é: {quadrado}");
            }
            else
            {
                Console.WriteLine("Por favor, digite um número inteiro positivo maior que zero.");
            }
            Validacao.AguardarTecla();
        }

        //16 Uma loja está levantando o valor total de todas as mercadorias em estoque. Criar um algoritmo que permita a entrada dos seguintes dados: 
        //1- o número total de mercadorias no estoque; 2- o valor de cada mercadoria. 
        //Ao final, apresentar na tela o valor total em estoque e a média dos valores das mercadorias.
        public static void Ex16()
        {
            int mercadoriaEstoque = Validacao.ValidarNumero("Digite o total de mercadorias no estoque: ");

            double valor = 0;

            for (int i = 1; i <= mercadoriaEstoque; i++)
            {
                int valorMercadoria = Validacao.ValidarNumero($"Digite o valor da {i} mercadoria: ");
                valor += valorMercadoria;

            }
            double total = valor / mercadoriaEstoque;
            Console.WriteLine($"Valor total em estoque: {valor}");
            Console.WriteLine($"Média dos valores das mercadorias: R${total}");

        }

        // 17 Um número inteiro é perfeito se o dobro dele é igual à soma de todos os seus divisores. 
        // Criar um algoritmo que leia um número inteiro positivo N e apresente na tela a lista de todos os números inteiros positivos perfeitos menores N.
        public static void Ex17()
        {
            int n = Validacao.ValidarNumero("Informe um número positivo: ");

            Console.WriteLine($"Números perfeitos menores que {n}:");

            bool encontrouPerfeito = false;

            for (int i = 2; i < n; i++) // Começando de 2 para excluir o 1
            {
                int somaDivisores = 1; // Incluindo o próprio número como divisor

                for (int j = 2; j <= i / 2; j++) // Ajustando a condição do loop interno
                {
                    if (i % j == 0)
                    {
                        somaDivisores += j;
                    }
                }

                if (somaDivisores == i)
                {
                    Console.WriteLine(i);
                    encontrouPerfeito = true;
                }
            }

            if (!encontrouPerfeito)
            {
                Console.WriteLine($"Não existem números perfeitos menores que {n}.");
            }
        }

        //18 -Criar um algoritmo que leia um número inteiro positivo e apresente na tela o número de algarismos deste número.
        public static void Ex18()
        {
            int numero = Validacao.ValidarNumero("Informe um número inteiro positivo: ");

            // Garante que o número seja não negativo
            if (numero < 0)
            {
                Console.WriteLine("Número inválido. Informe um número inteiro positivo.");
                return;
            }

            // Inicializa o contador de algarismos
            int numeroDeAlgarismos = 0;

            for (int i = numero; i != 0; i /= 10)
            {
                numeroDeAlgarismos++;
            }

            Console.WriteLine($"O número {numero} tem {numeroDeAlgarismos} algarismos.");
        }

        //19- Criar um algoritmo que apresente na tela os valores da conversão de graus Celsius em Fahrenheit, de 10 em 10, iniciando a contagem em 10 graus em terminando em 200 graus. 
        //A fórmula de conversão é: ​ F = C * 1.8 + 32
        public static void Ex19()
        {
            for (int celsius = 10; celsius <= 200; celsius += 10)
            {
                double fahrenheit = celsius * 1.8 + 32;
                Console.WriteLine($"Celsius: {celsius}, Fahrenheit: {fahrenheit}");
            }
            Validacao.AguardarTecla();
        }

        //20 Criar um algoritmo que apresente na tela os valores da conversão de graus Fahrenheit em Celsius, de 2 em 2, iniciando a contagem em 50 graus e terminando em 66 graus. 
        //A fórmula de conversão é: C = F - 32 / 1.8
        public static void Ex20()
        {
            for (int fahrenheit = 50; fahrenheit <= 66; fahrenheit += 2)
            {
                double celsius = (fahrenheit - 32) / 1.8;
                Console.WriteLine($"Fahrenheit: {fahrenheit}, Celsius: {celsius:F2}");

            }
            Validacao.AguardarTecla();
        }

        //21 Criar um algoritmo que leia dois números inteiros (positivos e maiores que zero) e apresente na tela o resultado da multiplicação dos números. 
        //Não utilize o operador de multiplicação "*". Use para a solução deste problema estrutura de repetição (laço).
        public static void Ex21()
        {
            int num1 = Validacao.ValidarNumero("Informe um número inteiro: ");
            int num2 = Validacao.ValidarNumero("Informe outro número inteiro: ");

            int resultado = 0;

            for (int i = 0; i < num2; i++)
            {
                resultado = +num1;
            }
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            Validacao.AguardarTecla();
        }

        //22 Criar um algoritmo que leia dois números inteiros (positivos e maiores que zero) e apresente na tela o resultado inteiro da divisão do primeiro pelo segundo número. 
        //Não utilize qualquer operador de divisão nem qualquer função para obter o resultado inteiro da divisão. Use para a solução deste problema estrutura de repetição (laço).
        public static void Ex22()
        {
            int num1 = Validacao.ValidarNumero("Informe o primeiro número: ");
            int num2 = Validacao.ValidarNumero("Informe o segundo número: ");

            int resultado = 0;

            // Enquanto num1 for maior ou igual a num2, subtrai num2 de num1 e incrementa o resultado
            while (num1 >= num2)
            {
                num1 -= num2;
                resultado++;
            }

            Console.WriteLine($"Resultado da divisão inteira: {resultado}");
            Validacao.AguardarTecla();
        }

        // 23 Criar um algoritmo que leia uma base e um expoente e apresente na tela o valor da potência da base pelo expoente. Considere apenas a entrada de valores inteiros e positivos (maiores que zero). 
        //Não utilize qualquer função para calcular a potência. Use para a solução deste problema estrutura de repetição (laço).
        public static void Ex23()
        {
            int baseNum = Validacao.ValidarNumero("Informe a base (número inteiro e positivo): ");
            int expoente = Validacao.ValidarNumero("Informe o expoente (número inteiro e positivo): ");

            if (baseNum <= 0 || expoente <= 0)
            {
                Console.WriteLine("Números inválidos. Certifique-se de que ambos são inteiros e positivos.");
                return;
            }

            int resultado = 1;

            for (int i = 1; i <= expoente; i++)
            {
                resultado *= baseNum;
            }

            Console.WriteLine($"O resultado da potência de {baseNum} elevado a {expoente} é: {resultado}");
            Validacao.AguardarTecla();
        }

        //24 Criar um algoritmo que apresente na tela a série de Fibonacci até o décimo quinto termo. A série de Fibonacci é formada pela seqüência: 1, 1, 2, 3, 5, 8, 13, 21, 34, ... etc., 
        //caracterizando-se pela soma de um termo posterior com o seu anterior subseqüente.
        public static void Ex24()
        {
            int termoAnterior = 0;
            int termoAtual = 1;

            Console.WriteLine(termoAnterior);

            for (int i = 1; i <= 14; i++) // segundo termo e imprimimos até o décimo quinto termo
            {
                Console.WriteLine(termoAtual);

                int proximoTermo = termoAnterior + termoAtual;
                termoAnterior = termoAtual;
                termoAtual = proximoTermo;
            }
        }

        //25 Criar um algoritmo que apresente todos os números inteiros divisíveis por 4 existentes na faixa de 1 a 200.
        public static void Ex25()
        {
            for (int i = 1; i <= 200; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        //26 Criar um algoritmo que apresente todos os números inteiros ímpares, existentes na faixa de 0 a 25.
        public static void Ex26()
        {
            Console.WriteLine("Números ímpares de 0 a 25:");
            for (int i = 0; i <= 25; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Validacao.AguardarTecla();
        }

        //27 Criar um algoritmo que apresente a média dos números inteiros divisíveis por 5 existentes na faixa de 0 a 136.
        public static void Ex27()
        {
            int soma = 0;
            int count = 0;

            for (int i = 0; i <= 136; i++)
            {
                if (i % 5 == 0)
                {
                    soma += i;
                    count++;
                    Console.WriteLine(i);
                }
            }

            if (count > 0)
            {
                double media = (double)soma / count;
                Console.WriteLine("Média: " + media);
            }
            Validacao.AguardarTecla();
        }

        //28 Criar um algoritmo que apresente a média dos números inteiros divisíveis por 7 existentes na faixa de 0 a 128.
        public static void Ex28()
        {
            int soma = 0;
            int count = 0;

            for (int i = 0; i <= 128; i++)
            {
                if (i % 7 == 0)
                {
                    soma += i;
                    count++;
                    Console.WriteLine(i);
                }
            }

            if (count > 0)
            {
                double media = (double)soma / count;
                Console.WriteLine("Média: " + media);
            }
            Validacao.AguardarTecla();
        }
    
    
    }
}