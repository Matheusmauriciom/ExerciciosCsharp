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
            int num = Validacao.ValidarNumero("Informe um número: ");
            Console.WriteLine(num < 0 ? $"O número {num} é negativo" : $"O número {num} é positivo");
            Validacao.AguardarTecla();
        }

        // 02 Criar um algoritmo que leia dois números L e R. O programa deve verificar a maior área entre um quadrado de lado L e um círculo de raio R. Imprimir na tela qual o maior: "Quadrado" ou "Circulo".
        public static void Ex2()
        {
            double ladoL = Validacao.ValidarNumeroDouble("Informe o lado do quadrado: ");
            double raioR = Validacao.ValidarNumeroDouble("Informe o raio do circulo: ");

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

        // 03 -Criar um algoritmo que leia três números e imprime o maior deles
        public static void Ex3()
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

        //04 Criar um algoritmo que leia um valor e apresente na tela se esse valor é positivo ou negativo (considere o valor zero como positivo).
        public static void Ex4()
        {
            double valor = Validacao.ValidarNumeroDouble("Informe um número: ");

            Console.WriteLine(valor < 0 ? $"O número {valor} é negativo" : $"O número {valor} é positivo");
            Validacao.AguardarTecla();
        }

        // 05 Criar um algoritmo que leia dois números e imprime a divisão do maior pelo menor.
        public static void Ex5()
        {
            double num1 = Validacao.ValidarNumeroDouble("Informe o primeiro número: ");
            double num2 = Validacao.ValidarNumeroDouble("Informe o segundo número: ");

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} / {num2} = {num1 / num2:F2}");
            }
            else if (num2 > num1)
            {
                Console.WriteLine($"{num2} / {num1} = {num2 / num1:F2}");
            }
            else
            {
                Console.WriteLine($" Os números são iguais! não é possivel fazer a operação...");
            }
            Validacao.AguardarTecla();
        }

        //06 - Criar um algoritmo que leia uma velocidade e caso o valor lido seja maior que 70 apresentar na tela Multado.
        public static void Ex6()
        {
            double velocidade = Validacao.ValidarNumeroDouble("Informe e velocidade do veículo: ");
            Console.WriteLine(velocidade >= 70 ? "Multado" : "Não multado");
            Validacao.AguardarTecla();
        }

        // 07 - Criar um algoritmo que leia uma velocidade, caso o valor lido for maior que 70 apresentar na tela a mensagem Multado, caso contrário apresentar na tela a mensagem Não Multado.
        public static void Ex7()
        {
           double velocidade = Validacao.ValidarNumeroDouble("Informe e velocidade do veículo: ");
            Console.WriteLine(velocidade >= 70 ? "Multado" : "Não multado");
            Validacao.AguardarTecla();
        }

        //08 - Uma empresa decide dar aumento de 15% aos funcionários cujo salário é inferior a 500 reais. 
        //Criar um algoritmo que leia o salário de um funcionário e apresente na tela o valor do salário reajustado ou o valor do salário informado caso ele não tenho direito ao reajuste. */
        public static void Ex8()
        {
            double salario = Validacao.ValidarNumeroDouble("Informe seu salário: ");
            if (salario < 500)
            {
                double reajuste = salario * 15 / 100;
                Console.WriteLine($"Seu salário reajustado é de {salario + reajuste}");
            }
            else
            {
                Console.WriteLine($"Seu salário é de {salario} e você não tem direito ao reajuste.");
            }
            Validacao.AguardarTecla();
        }

        //09 Criar um algoritmo que leia o valor de uma conta de luz e, caso o valor seja maior que R$ 50,00 e menor que R$ 500,00 apresente na tela a mensagem Você está gastando muito. Caso contrário não exiba mensagem nenhuma.
        public static void Ex9()
        {
            double valorLuz = Validacao.ValidarNumeroDouble("Informe o valor da conta de luz: ");
            if (valorLuz >= 50 && valorLuz <= 500)
            {
                Console.WriteLine("Você está gastando muito");
            }
            Validacao.AguardarTecla();
        }

        //10- Criar um algoritmo que leia o valor total de vendas do mês de um determinado vendedor e o seu nome, e apresente na tela o nome do vendedor quando o valor da venda estiver entre R$ 1.000,00 e R$ 5.000,00.
        public static void Ex10()
        {
            string nome = Validacao.ValidarString("Informe seu nome: ");

            double vendas = Validacao.ValidarNumeroDouble("Informe o total de vendas deste mês: ");

            if (vendas >= 1000 && vendas <= 5000)
            {
                Console.WriteLine(nome);
            }
            else
            {
                Console.WriteLine($"Desculpe, {nome}, o valor de vendas não atende aos critérios desejados.");
            }
            Validacao.AguardarTecla();
        }

        //11 - Criar um algoritmo que leia um valor numérico inteiro positivo ou negativo e apresentar o valor lido como sendo um valor positivo, ou seja, se o valor lido for menor que zero, ele deve ser multiplicado por -1.
        public static void Ex11()
        {
            int numero = Validacao.ValidarNumero("Informe um número inteiro negativo ou positivo: ");

            if (numero < 0)
            {
                int resultado = numero * -1;
                Console.WriteLine($"O número informado é negativo, então ele será convertido para positivo: {resultado}");
            }
            else
            {
                Console.WriteLine($"O número {numero} é positivo.");
            }
            Validacao.AguardarTecla();
        }

        //12 Criar um algoritmo que leia um número inteiro e apresente na tela o número lido caso ele seja divisível por 4 mas não por 5.
        public static void Ex12()
        {
            int numero = Validacao.ValidarNumero("Informe um número inteiro: ");
            if (numero % 4 == 0 && numero % 5 != 0)
            {
                Console.WriteLine("O número atende aos critérios: é divisível por 4, mas não por 5.");
            }
            else
            {
                Console.WriteLine("O número não atende aos critérios: não é divisível por 4 ou é divisível por 5.");
            }
            Validacao.AguardarTecla();
        }

        //13 Criar um algoritmo que leia duas variáveis do tipo lógico, caso ambas sejam verdadeiras apresentar na tela Tem Desconto.
        public static void Ex13()
        {

            Console.Write("Informe o valor da primeira variável (true/false): ");
            bool primeiraCondicao = bool.Parse(Console.ReadLine());

            Console.Write("Informe o valor da segunda variável (true/false): ");
            bool segundaCondicao = bool.Parse(Console.ReadLine());

            if (primeiraCondicao && segundaCondicao)
            { Console.WriteLine("Tem Desconto"); }

            else
            { Console.WriteLine("Não tem Desconto"); }
            Validacao.AguardarTecla();
        }

    }
}