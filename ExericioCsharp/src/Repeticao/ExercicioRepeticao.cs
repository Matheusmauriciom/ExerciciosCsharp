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
    
    
    }
}