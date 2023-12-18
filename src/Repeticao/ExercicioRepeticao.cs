using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExericioCsharp.src.Repeticao
{
    public class ExercicioRepeticao
    {
        //01 Criar um algoritmo que apresente o quadrado dos números inteiros de 15 a 200.
        public static void Ex1()
        {

            for (int i = 15; i <=200; i++)
            {
                Console.WriteLine($"O quadrado de {i} é {i*i}");
            }
            Validacao.AguardarTecla();
        }
    
        //02 Criar um algoritmo que apresente na tela os números de 1 a 50 em ordem decrescente.
        public static void Ex2()
        {   
            for (int i = 50; i >=1; i--)
            {
                Console.WriteLine(i);
            }
            Validacao.AguardarTecla();
        }   

        //03 Criar um algoritmo que calcule e apresente na tela a tabuada do 8 (1 a 10).
        public static void Ex3()
        {
           for (int i = 1; i <= 10; i++)
           {
            Console.WriteLine($"8 x {i} = {i*8}");
           }
           Validacao.AguardarTecla();
        }

        //04 Criar um algoritmo que leia um número inteiro positivo e apresente na tela a sua tabuada (1 a 10).
        public static void Ex4()
        {
            int numero = Validacao.ValidarNumero("Informe um número inteiro e positivo");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {i*numero}");
            }
            Validacao.AguardarTecla();
        }
    
        //05 Criar um algoritmo que apresente na tela o total da soma dos cem primeiros números inteiros positivos (1 + 2 + 3 + ... + 98 + 99 + 100).
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
    
        //06 Criar um algoritmo que apresente os valores da conversão de polegadas para centímetros, de 3 em 3, iniciando a contagem em 1 polegada e terminando em 13 polegadas. 
        //Uma polegada equivale a aproximadamente 2,54 centímetros.
        public static void Ex6()
        {
            double polegada = 2.54;

            for (int i = 1; i <= 13; i += 3)
            {   
                double centimetros = polegada * i;
                Console.WriteLine($"Polegada {i}: {centimetros} cm");
                
            }
        }
    
    
    }
}