using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        // 02 -Criar um algoritmo que leia três números e imprime o maior deles..
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
            Console.WriteLine(velocidade >=70 ? "Multado" : "Não multado");
            Validacao.AguardarTecla();
        }
    
    
    }
}