using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExericioCsharp.src
{
    public class Validacao
    {
        public static int ValidarNumero(string mensagem)
        {   Console.Clear();
            int numero;
            bool entradaValida = false;

            do
            {   //solicita ao usuário que insira um número
                Console.WriteLine(mensagem);


                string input = Console.ReadLine();

                //tenta converter a entrada para um numero inteiro
                if (int.TryParse(input, out numero))
                {   //true o loop encerra
                    entradaValida = true;
                }
                else
                    //false exibe msg de erro 
                    Console.WriteLine("Por favor, digite um número válido");
            }
            while (!entradaValida);
            //retorna o numero válido
            return numero;
        }
        public static string ValidarString(string mensagem)
        {
            string input;

            do
            {   //solicita ao usuário que insira uma string
                Console.Write(mensagem);
                input = Console.ReadLine();

                //verifica se a entrada pode ser convertida para um num
                if (int.TryParse(input, out _))
                {   
                    //conversao for possivel = erro
                    Console.WriteLine("Porfavor, digite apenas texto, não números.");
                }
            } while (int.TryParse(input, out _));

            //retorn a string válida que foi inserada
            return input;
        } 
        public static void AguardarTecla()
        {   Console.WriteLine();
            Console.WriteLine("Precione qualquer tecla para finalizar...");
            Console.ReadKey();
        }
    }
}