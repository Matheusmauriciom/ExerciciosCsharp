using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ExericioCsharp.src.Decisao
{
    public class ExercicioDecisao
    {   //01 Criar um algoritmo que lê um número e verifica se ele é negativo. Se for negativo, imprimir na tela a mensagem "Numero negativo".
        public static void Ex1()
        {
            int num = Validacao.ValidarNumero("Informe um número");
            Console.WriteLine(num < 0 ? $"O número {num} é negativo" : $"O número {num} é positivo");
            Validacao.AguardarTecla();
        }

        // 02 -Criar um algoritmo que leia três números e imprime o maior deles
        public static void Ex2()
        {
            Console.WriteLine("Informe 3 números inteiros:");
            int num1 = Validacao.ValidarNumero("Informe o primeiro número: ");
            int num2 = Validacao.ValidarNumero("Informe o segundo número: ");
            int num3 = Validacao.ValidarNumero("Informe o terceiro número: ");

            // Encontrar o maior número
            int maiorNumero = Math.Max(Math.Max(num1, num2), num3);

            // Verificar se todos são iguais
            if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine("Todos os números são iguais.");
            }
            else
            {
                Console.WriteLine($"O maior número é: {maiorNumero}");
            }
            Validacao.AguardarTecla();
        }

        //03 - Criar um algoritmo que leia uma velocidade e caso o valor lido seja maior que 70 apresentar na tela Multado.
        public static void Ex3()
        {
            int velocidade = Validacao.ValidarNumero("Informe e velocidade do veículo: ");
            Console.WriteLine(velocidade >= 70 ? "Multado" : "Não multado");
            Validacao.AguardarTecla();
        }

        //04 - Uma empresa decide dar aumento de 15% aos funcionários cujo salário é inferior a 500 reais. 
        //Criar um algoritmo que leia o salário de um funcionário e apresente na tela o valor do salário reajustado ou o valor do salário informado caso ele não tenho direito ao reajuste. */
        public static void Ex4()
        {
            int salario = Validacao.ValidarNumero("Informe seu salário: ");
            if (salario < 500)
            {
                double reajuste = salario * 15 / 100;
                System.Console.WriteLine($"Seu salário reajustado é de {salario + reajuste}");
            }
            else
            {
                System.Console.WriteLine($"Seu salário é de {salario} e você não tem direito ao reajuste.");
            }
            Validacao.AguardarTecla();
        }

        //05 Criar um algoritmo que leia o valor de uma conta de luz e, caso o valor seja maior que R$ 50,00 e menor que R$ 500,00 apresente na tela a mensagem Você está gastando muito. Caso contrário não exiba mensagem nenhuma.
        public static void Ex5()
        {
            int valorLuz = Validacao.ValidarNumero("Informe o valor da conta de luz: ");
            if (valorLuz >= 50 && valorLuz <= 500)
            {
                Console.WriteLine("Você está gastando muito");
            }
        }

        // 06 Criar um algoritmo que leia dois números L e R. O programa deve verificar a maior área entre um quadrado de lado L e um círculo de raio R. Imprimir na tela qual o maior: "Quadrado" ou "Circulo".
        public static void Ex6() // area quadrado
        {
            double ladoL = Validacao.ValidarNumero("Informe o lado do quadrado:");
            double raioR = Validacao.ValidarNumero("Informe o raio do circulo:");

            // double areaQuadrado = ladoL * ladoL;
            double areaQuadrado = Math.Pow(ladoL, 2);

            // double areaCirculo = 3.1415 * raioR * raioR;
            double areaCirculo = Math.PI * Math.Pow(raioR, 2);

            Console.WriteLine($"A área do quadrado é de: {areaQuadrado:F2}");
            Console.WriteLine($"A área do círculo é de: {areaCirculo:F2}");
            Console.WriteLine("");

            string resultado = areaQuadrado > areaCirculo ? "Quadrado é maior" : "Circulo é maior";
            Console.WriteLine(resultado);
            Validacao.AguardarTecla();

        }
    
    
    }
}