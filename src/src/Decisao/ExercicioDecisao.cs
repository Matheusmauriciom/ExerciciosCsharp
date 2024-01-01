using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
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

        //14 Criar um algoritmo que leia um número inteiro e apresente na tela o número lido caso ele seja divisível por 2 e 3. 
        public static void Ex14()
        {
            int num = Validacao.ValidarNumero("Informe um número intero: ");

            if (num % 2 == 0 && num % 3 == 0)
            {
                Console.WriteLine($"O número {num} é divisível por 2 e 3");
            }
            else
            {
                Console.WriteLine($"O número {num} não é divisível por 2 e 3");
            }
            Validacao.AguardarTecla();
        }

        //15 Criar um algoritmo que leia um número inteiro e apresente na tela o número lido caso ele seja divisível por 4 ou 5.
        public static void Ex15()
        {
            int num = Validacao.ValidarNumero("Informe um número intero: ");

            if (num % 4 == 0 || num % 5 == 0)
            {
                Console.WriteLine($"O número {num} é divisível por 4 ou 5");
            }
            else
            {
                Console.WriteLine($"O número {num} não é divisível por 4 ou 5");
            }
            Validacao.AguardarTecla();
        }

        // 16 Criar um algoritmo que leia dois números inteiros e apresente uma mensagem indicando se o primeiro número é múltiplo do segundo.
        public static void Ex16()
        {
            int num1 = Validacao.ValidarNumero("Informe um número inteiro: ");
            int num2 = Validacao.ValidarNumero("Informe outro número inteiro: ");

            if (num2 != 0 && num2 == 0)
            {
                Console.WriteLine($"{num1} é múltiplo de {num2}.");
            }
            else
            {
                Console.WriteLine($"{num1} não é múltiplo de {num2}.");
            }
            Validacao.AguardarTecla();
        }

        // 17 As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia. E R$ 1,00 se forem compradas pelo menos 12. 
        //Criar um algoritmo que leia o número de maçãs compradas, calcule e apresente na tela o custo total da compra.
        public static void Ex17()
        {

            int numeroMaca = Validacao.ValidarNumero("Informe o número de maças compradas: ");

            if (numeroMaca < 12)
            {
                double total = numeroMaca * 1.30;
                Console.WriteLine($"O valor total na compra de {numeroMaca} maças é de R${total:F2} reais.");
            }
            else
            {
                double total = numeroMaca * 1.00;
                Console.WriteLine($"O valor total na compra de {numeroMaca} maças é de R${total:F2} reais.");
            }
            Validacao.AguardarTecla();

        }

        // 18 Criar um algoritmo que leia dois valores inteiros (considere que não serão lidos valores iguais) e apresente-os em ordem crescente.
        public static void Ex18()
        {
            int num1 = Validacao.ValidarNumero("Inform um número inteiro: ");
            int num2 = Validacao.ValidarNumero("Inform outro número inteiro: ");

            if (num1 > num2)
            {
                Console.WriteLine($"{num2} {num1}");
            }
            else if (num2 > num1)
            {
                Console.WriteLine($"{num1} {num2}");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Operação inválida, os dois números são iguais.");
            }
            Validacao.AguardarTecla();

        }

        //19 Criar um algoritmo que leia a idade de uma pessoa e apresente na tela uma mensagem de maioridade ou não.
        public static void Ex19()
        {
            int idade = Validacao.ValidarNumero("Informe sua idade: ");
            Console.WriteLine(idade < 18 ? "Menor de idade" : "Maior de idade");
            Validacao.AguardarTecla();

        }

        //20 Criar um algoritmo que leia o salário de um funcionário, calcule e apresente o salário reajustado, de acordo com a seguinte regra: 
        // salários até R$ 300, reajuste de 15%; 
        // salários maiores que R$ 300, reajuste de 7,5%.
        public static void Ex20()
        {

            double salario = Validacao.ValidarNumeroDouble("Informe seu salário: ");
            if (salario <= 300)
            {
                double reajusteMenor = salario * 15 / 100;
                Console.WriteLine($"Seu salário foi reajustado em R${reajusteMenor} reais. Totalizando em {salario + reajusteMenor:C} reais.");
            }
            else
            {
                double reajusteMaior = salario * 7.5 / 100;
                Console.WriteLine($"Seu salário foi reajustado em R${reajusteMaior} reais. Totalizando em {salario + reajusteMaior:C} reais.");
            }
            Validacao.AguardarTecla();
        }

        //21 Criar um algoritmo que leia o ano atual e o ano de nascimento de uma pessoa. 
        //Apresentar na tela uma mensagem que diga se ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).
        public static void Ex21()
        {
            int anoAtual = Validacao.ValidarNumero("Informe o ano atual: ");
            int anoNascimento = Validacao.ValidarNumero("Informe o ano em que nasceu: ");

            int idade = anoAtual - anoNascimento;
            Console.WriteLine(idade < 18 ? "Não pode votar esse ano." : $"Você poderá votar, pois é menor de idade.");
        }

        //22 Uma livraria esta fazendo uma promoção para pagamento à vista em que o comprador pode escolher entre dois critérios de desconto: 
        // Critério A: R$ 0,25 por livro + R$ 7,50 fixo;
        // Critério B: R$ 0,50 por livro + R$ 2,50 fixo.
        // Criar um algoritmo em que o usuário informe a quantidade de livros que deseja comprar e o programa diz qual é a melhor opção de desconto.
        public static void Ex22()
        {
            int qtdadeLivros = Validacao.ValidarNumero("Informe a quantidade de livros que deseja comprar: ");

            double criterioA = qtdadeLivros * 0.25 + 7.50;
            double criterioB = qtdadeLivros * 0.50 + 2.50;

            if (criterioA < criterioB)
            {
                Console.WriteLine($"Melhor opção: Criterio A - R${criterioA:F2}");
            }
            else
            {
                Console.WriteLine($"Melhor opção: Criterio B - R${criterioB:F2}");
            }
        }

        //23 Criar um algoritmo que leia a altura e o sexo de uma pessoa (M ou F) e apresente o seu peso ideal, utilizando a seguinte fórmula:
        // para homens: (72.7 * altura) - 58
        // para mulheres: (62.1 * altura) - 44.7
        public static void Ex23()
        {
            string sexo = Validacao.ValidarString("Informe seu sexo(M/F): ").ToUpper();

            double altura = Validacao.ValidarNumeroDouble("Informe sua aproximadamente sua altura: ");

            if (sexo == "M" || sexo == "MASCULINO")
            {
                double peso = (72.7 * altura) - 58;
                Console.WriteLine($"Seu peso ideal é de {peso}KG");
            }
            else if (sexo == "F" || sexo == "FEMININO")
            {
                double peso = (62.1 * altura) - 44.7;
                Console.WriteLine($"Seu peso ideal é de {peso}KG");
            }
            else
            {
                Console.WriteLine("Sexo inválido. Por favor, informe 'M' para masculino ou 'F' para feminino.");
            }
            Validacao.AguardarTecla();

        }

        // 24 Criar um algoritmo que leia a hora de início e a hora de fim de um jogo de Xadrez (considere apenas horas inteiras, sem os minutos), 
        //calcule e apresente na tela a duração do jogo em horas, sabendo-se que o tempo máximo de duração do jogo é de 24 horas e que o jogo pode iniciar em um dia e terminar no dia seguinte.
        public static void Ex24()
        {
            int horaInicio = Validacao.ValidarNumero("Informe a hora do início da partida: ");
            int horaFinal = Validacao.ValidarNumero("Informe a hora do final da partida: ");

            int duracao;

            if (horaInicio > horaFinal)
            {
                duracao = (24 - horaInicio) + horaFinal;
            }
            else
            {
                duracao = horaFinal - horaInicio;
            }

            Console.WriteLine($"A duração do jogo é de {duracao} horas.");
            Validacao.AguardarTecla();
        }

        // 25 Criar um algoritmo que efetue o cálculo do reajuste de salário de um funcionário. Considere que o funcionário deve receber um reajuste de 15% caso seu salário seja menor que R$ 500,00. 
        //Se o salário for maior ou igual a R$ 500,00 mas menor ou igual a R$ 1.000,00, seu reajuste será de 10%; caso seja ainda maior que R$ 1.000,00, o reajuste deverá ser de 5%.
        public static void Ex25()
        {

            double salario = Validacao.ValidarNumeroDouble("Informe seu salário: ");
            double novoSalario = 0;

            if (salario < 500)
            {
                double reajuste15 = salario * 15 / 100;
                novoSalario = salario + reajuste15;
                Console.WriteLine($"Você recebeu o reajuste de 15%, seu novo salário é de {novoSalario:C}");
            }
            else if (salario >= 500 && salario <= 1000)
            {
                double reajuste10 = salario * 10 / 100;
                novoSalario = salario + reajuste10;
                Console.WriteLine($"Você recebeu o reajuste de 10%, seu novo salário é de {novoSalario:C}");
            }
            else
            {
                double reajuste05 = salario * 5 / 100;
                novoSalario = salario + reajuste05;
                Console.WriteLine($"Você recebeu o reajuste de 5%, seu novo salário é de {novoSalario:C}");
            }
            Validacao.AguardarTecla();
        }

        // 26 Criar um algoritmo que leia o peso e a altura de uma pessoa, calcule o seu IMC (Índice de Massa Corporal), e apresente na tela uma mensagem informando se a pessoa está ou não no seu peso ideal, de acordo com a tabela abaixo. 
        //A fórmula para calcular o IMC é:  peso  / altura 2    
        /* 
            IMC < 20                Abaixo do peso
            20 <= IMC < 25          Peso ideal
            IMC >= 25               Acima do pesoa  */
        public static void Ex26()
        {
            double peso = Validacao.ValidarNumeroDouble("Informe o seu peso:");
            double altura = Validacao.ValidarNumeroDouble("Infome sua altura: ");

            double imc = peso / (altura * altura);
            if (imc < 20)
            {
                Console.WriteLine("Abaixo do peso.");
            }
            else if (imc >= 20 && imc < 25)
            {
                Console.WriteLine("Peso ideal");
            }
            else
            {
                Console.WriteLine("Acima do peso");
            }
            Console.WriteLine($"IMC: {imc:F2}");
            Validacao.AguardarTecla();
        }

        // 27 Criar um algoritmo que leia o código de origem de um produto e apresente na tela a sua procedência. A procedência obedece a seguinte tabela:

        /*  Código de Origem // Procedência 
            5 ou 6               Nordeste                   
            7, 8 ou 9            Sudeste   
            10 até 20            Centro-Oeste
            21 até 30            Nordeste */
        public static void Ex27()
        {
            int codigo = Validacao.ValidarNumero("Informe um número o código do produto: ");
            if (codigo >= 5 && codigo <= 6)
            {
                Console.WriteLine("Procedência: Nordeste.");
            }
            else if (codigo >= 7 && codigo <= 9)
            {
                Console.WriteLine("Procedência: Sudeste.");
            }
            else if (codigo >= 10 && codigo <= 20)
            {
                Console.WriteLine("Procedência: Centro-Oeste.");
            }
            else if (codigo >= 21 && codigo <= 30)
            {
                Console.WriteLine("Procedência: Nordeste.");
            }
            else
            {
                Console.WriteLine("Código inválido.");
            }
            Validacao.AguardarTecla();
        }

        // 28 Criar um algoritmo que leia o salário de um funcionário e calcule o imposto de renda (IR) a ser pago a partir do salário do funcionário. 
        //Se o salário for menor que R$ 1.257,12 está isento do imposto. 
        //Se o salário for entre R$ 1.257,12 e R$ 2.510,00 (inclusive), a alíquota do imposto é 17%. 
        //Se o salário for superior a R$ 2.510,00, a alíquota do imposto é 28%. 
        //Apresentar na tela o salário bruto, o salário líquido e o valor do imposto.
        public static void Ex28()
        {
            double salario = Validacao.ValidarNumeroDouble("Informe seu salário: ");
            double imposto = 0;
            if (salario < 1257.12)
            {
                Console.WriteLine("Isento do imposto");
            }
            else if (salario >= 1257.12 && salario <= 2510.00)
            {
                imposto = salario * 17 / 100;
                Console.WriteLine($"Salário Bruto: {salario:C}");
                Console.WriteLine($"Você terá que pagar {imposto:C} de imposto.");
            }
            else
            {
                imposto = salario * 28 / 100;
                Console.WriteLine($"Salário Bruto: {salario:C}");
                Console.WriteLine($"Você terá que pagar {imposto:C} de imposto.");
            }
            double salarioLiquido = salario - imposto;
            Console.WriteLine($"Salário Líquido: {salarioLiquido:C}");
            Validacao.AguardarTecla();
        }

        //29 [ARRAY] Criar um algoritmo que leia o valor de três notas escolares de um aluno. Calcular a média aritmética e apresentar na tela a mensagem Aprovado se a média obtida for maior ou igual a 7; 
        //caso contrário, o algoritmo deve solicitar a nota de exame do aluno e calcular uma nova média aritmética entre a nota do exame e a primeira média aritmética. 
        //Se o valor da nova média for maior ou igual a 5, apresentar na tela a mensagem Aprovado em exame'; 
        //caso contrário, apresentar a mensagem Reprovado. Informar junto com cada mensagem o valor da média obtida.
        public static void Ex29()
        {
            double[] notas = new double[3];

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write($"Informe a {i + 1}ª nota: ");
                notas[i] = double.Parse(Console.ReadLine());
            }

            double media = notas.Sum() / notas.Length;

            if (media >= 7)
            {
                Console.WriteLine("Aprovado");
                Console.WriteLine($"Média: {media}");
            }
            else

            {
                Console.WriteLine();
                Console.WriteLine("Você ficou de recuperação.");
                Console.Write("Informe a nota do exame(recuperação): ");
                double exame = double.Parse(Console.ReadLine());
                notas[0] = exame;

                double novaMedia = notas.Sum() / notas.Length;
                if (novaMedia <= 5)
                {
                    Console.WriteLine($"Reprovado em exame(recuperação). Sua média ficou em {novaMedia:F2}");
                }
                else
                {
                    Console.WriteLine($"Aprovado em exame(recuperação). Sua média ficou em {novaMedia:F2}");
                }
            }

        }
    
        //30 Criar um algoritmo que leia dois números inteiros e apresente na tela uma mensagem indicando se são iguais ou diferentes. 
        //Se os números são diferentes, apresentar na tela o maior e o menor número (nesta sequência).
        public static void Ex30()
        {
            int num1 = Validacao.ValidarNumero("Informe um número inteiro: ");
            int num2 = Validacao.ValidarNumero("Informe outro número inteiro: ");

            if (num1 != num2)
            {
                if(num1 > num2){
                    Console.WriteLine($"{num1} é maior e {num2} é menor.");
                }
                else{
                    Console.WriteLine($"{num2} é maior e {num1} é menor");
                }
            }
            else{
                Console.WriteLine($"{num1} e {num2} são iguais."); }
        }
    }
}