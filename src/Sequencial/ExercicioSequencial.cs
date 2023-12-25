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
            double num = Validacao.ValidarNumero("Informe um número: ");
            Console.WriteLine($"O sucecessor de {num} é {num + 1}");
            Console.WriteLine($"O antecedente de {num} é {num - 1}");

            Validacao.AguardarTecla();
        }

        //02- Criar um algoritmo que lê dois números inteiros e imprime os números consecutivos desses números. 
        // (Por exemplo: se o usuário digitar 2 e -­9, a saída deverá ser 3 e -­8.
        public static void Ex2()
        {
            int num1 = Validacao.ValidarNumero("Informe o primeiro número: ");
            int num2 = Validacao.ValidarNumero("Informe o segundo número: ");

            Console.WriteLine($"O consecutivo de {num1} é {num1 + 1}");
            Console.WriteLine($"O consecutivo de {num2} é {num2 + 1}");
            Validacao.AguardarTecla();
        }

        //03-Criar um algoritmo que leia dois números inteiros e apresenta na tela a soma, subtração, multiplicação e divisão dos respectivos números.
        public static void Ex3()
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

        //04 - Criar um algoritmo que leia dois números inteiros e apresente na tela o resto da divisão do primeiro pelo segundo número
        public static void Ex4()
        {
            int num1 = Validacao.ValidarNumero("Informe um número inteiro: ");
            int num2 = Validacao.ValidarNumero("Informe outro número inteiro: ");

            int resto = num1 % num2;
            Console.WriteLine($"O resto da divisão de {num1} por {num2} é de {resto}");
            Validacao.AguardarTecla();
        }

        //05- Criar um algoritmo que leia a idade de uma pessoa expressa em anos e apresente na tela esta idade expressa em meses e dias.
        public static void Ex5()
        {
            int idade = Validacao.ValidarNumero("Informe sua idade: ");

            int dias = 365 * idade;
            Console.WriteLine($"Você tem {idade} anos de idade e aproximadamente {dias} dias de vida");
            int meses = 360 * idade / 30;
            Console.WriteLine($"Você tem {idade} anos de idade e  aproximadamente {meses} meses de vida");
            Validacao.AguardarTecla();

        }

        //06 - Criar um algoritmo que leia a idade de uma pessoa expressa em anos, mês e dias e apresente na tela a idade dessa pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias.
        public static void Ex6()
        {
            int idade = Validacao.ValidarNumero("Informe sua idade em anos:");
        }

        //07 Criar um algoritmo que leia a idade de uma pessoa expressa em dias, e apresente na tela a idade dessa pessoa expressa em anos, meses e dias. Considerar ano com 365 dias e mês com 30 dias.
        public static void Ex7()
        {
            int dias = Validacao.ValidarNumero("Informe sua idade em dias: ");

            int diasPorAno = 365;
            int diasPorMes = 30;

            int idadeAnos = dias / diasPorAno; // Calcula o número de anos completos
            int diasRestantes = dias % diasPorAno; // Calcula os dias restantes após os anos

            int idadeMeses = diasRestantes / diasPorMes; // Calcula o número de meses completos
            int idadeDias = diasRestantes % diasPorMes; // Calcula os dias restantes após os meses

            Console.WriteLine($"Sua idade é de {idadeAnos} anos, {idadeMeses} meses e {idadeDias} dias.");
            Validacao.AguardarTecla();
        }

        //08 Criar um algoritmo que receba uma determinada hora (hora e minutos separados) e apresente na tela a hora em minutos.
        public static void Ex8()
        {
            int horas = Validacao.ValidarNumero("Informe a hora (formato 24 horas): ");
            int minutos = Validacao.ValidarNumero("Informe os minutos: ");

            if (horas >= 0 && horas <= 23 && minutos >= 0 && minutos <= 59)
            {
                int horaMinuto = (horas * 60) + minutos;
                Console.WriteLine($"O total de horas em minutos é de {horaMinuto} minutos.");
            }
            else
            {
                Console.WriteLine("Por favor, insira horas e minutos válidos.");
            }
            Validacao.AguardarTecla();
        }

        //09 Criar um algoritmo que leia o tempo de duração de um evento em uma fábrica expressa em segundos e apresente-o na tela expresso em horas, minutos e segundos.
        public static void Ex9()
        {
            int duracaoSegundos = Validacao.ValidarNumero("Qual o tempo de duração do evento em segundos? ");

            int segundosPorHora = 3600; // 1 hora = 3600 segundos
            int segundosPorMinuto = 60; // 1 minuto = 60 segundos

            int horas = duracaoSegundos / segundosPorHora; // Calcula o número de horas completas
            int minutosRestantes = (duracaoSegundos % segundosPorHora) / segundosPorMinuto; // Calcula os minutos restantes
            int segundosRestantes = duracaoSegundos % segundosPorMinuto; // Calcula os segundos restantes

            Console.WriteLine($"A duração do evento é de {horas} horas, {minutosRestantes} minutos e {segundosRestantes} segundos.");
            Validacao.AguardarTecla();
        }

        //10 Criar um algoritmo que leia uma velocidade fornecida em m/s (metros por segundo) e apresente na tela a velocidade em km/h. Para efetuar a conversão, multiplique o valor em m/s por 3.6.
        public static void Ex10()
        {
            int velocidadeMs = Validacao.ValidarNumero("Informe a velocidade em m/s (metros por segundo): ");

            double velocidadeKm = velocidadeMs * 3.6;
            Console.WriteLine($"A velocidade de {velocidadeMs} m/s é de: {velocidadeKm} km/h");
            Validacao.AguardarTecla();
        }

        //11 Criar um algoritmo que receba o valor do salário de um funcionário e o valor do salário mínimo e apresente na tela quantos salários mínimos ganha esse funcionário.
        public static void Ex11()
        {
            double salario = Validacao.ValidarNumeroDouble("Informe seu salário: ");
            double valorSalarioMin = 1320.00;

            double total = salario / valorSalarioMin;

            Console.WriteLine($"Você recebe o total de {total:F2} salários mínimos");
            Validacao.AguardarTecla();
        }

        //12 Criar um algoritmo que leia uma distância e o total de litros de combustível gasto por um automóvel para percorrê-la, calcule e apresente na tela o consumo médio de combustível.
        public static void Ex12()
        {
            double distancia = Validacao.ValidarNumeroDouble("Informe a distância do seu destino: ");
            double combustivel = Validacao.ValidarNumeroDouble("Informe o total de listros gasto para percorrer: ");


            double consumoMedio = distancia / combustivel;
            Console.WriteLine($"O consumo médio gasto para percorrer a distancia de {distancia} Km é de {consumoMedio:F2}");
            Validacao.AguardarTecla();
        }

        //13 Criar um algoritmo que receba três notas de um aluno e apresente na tela a média aritmética entre essas notas.
        public static void Ex13()
        {
            double nota1 = Validacao.ValidarNumeroDouble("Informe a primeira nota: ");
            double nota2 = Validacao.ValidarNumeroDouble("Informe a segunda nota: ");
            double nota3 = Validacao.ValidarNumeroDouble("Informe a terceira nota: ");

            double media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine($"A média das notas foi de: {media:F2}");
            Validacao.AguardarTecla();
        }

        //14 Criar um programa que calcule e apresente na tela a área de um retângulo. Fórmula: area = base.altura
        public static void Ex14()
        {
            double areaRetangulo = Validacao.ValidarNumeroDouble("Informe a área d");
        }
    }
}