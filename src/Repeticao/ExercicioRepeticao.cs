using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}