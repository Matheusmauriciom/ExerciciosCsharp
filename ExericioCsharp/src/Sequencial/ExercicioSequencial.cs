using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExericioCsharp.src.Sequencial
{
    public class ExercicioSequencial
    {   
        //01-Criar um algoritmo que leia um número inteiro e apresente na tela o seu antecedente e o seu sucessor.
        public static void Ex1()
        {

            int num = Validacao.ValidarNumero("Informe um número");
            Console.WriteLine($"O sucecessor de {num} é {num+1}");
            Console.WriteLine($"O antecedente de {num} é {num-1}");
            
            Validacao.AguardarTecla();
        }

         //02-Criar um algoritmo que leia dois números inteiros e apresenta na tela a soma, subtração, multiplicação e divisão dos respectivos números.
        public static void Ex2()
        {
           
            int num1 = Validacao.ValidarNumero("Informe um número inteiro");
            int num2 = Validacao.ValidarNumero("Informe outro número inteiro");

            int soma = num1 + num2;
            int div = num1 / num2;
            int sub = num1 - num2;
            int multi = num1 * num2;

            Console.WriteLine($"A soma de {num1} + {num2} = {soma}");
            Console.WriteLine($"A subtração de {num1} - {num2} = {sub}");
            Console.WriteLine($"A divisão de {num1} / {num2} = {div}");
            Console.WriteLine($"A multiplicação de {num1} * {num2} = {multi}");
            Validacao.AguardarTecla();
        }

        //03- Criar um algoritmo que leia a idade de uma pessoa expressa em anos e apresente na tela esta idade expressa em meses e dias.
        public static void Ex3()
        {
            int idade = Validacao.ValidarNumero("Informe sua idade: ");
            

        }
    }
}