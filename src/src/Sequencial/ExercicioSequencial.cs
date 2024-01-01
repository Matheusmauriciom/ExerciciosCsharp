using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ExericioCsharp.src.Sequencial
{
    public class ExercicioSequencial
    {
        //01-Criar um algoritmo que leia um número inteiro e apresente na tela o seu antecedente e o seu sucessor.
        public static void Ex1()
        {
            int num = Validacao.ValidarNumero("Informe um número: ");
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
            int anos = Validacao.ValidarNumero("Informe sua idade em anos:");
            int meses = Validacao.ValidarNumero("Informe o número de meses:");
            int dias = Validacao.ValidarNumero("Informe o número de dias:");

            int idadeEmDias = anos * 365 + meses * 30 + dias;

            Console.WriteLine($"Sua idade em dias é: {idadeEmDias} dias.");
            Validacao.AguardarTecla();
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
            double baseRetangulo = Validacao.ValidarNumeroDouble("Informe a altura (h) do retângulo: ");
            double alturaRetangulo = Validacao.ValidarNumeroDouble("Informe a base (b) retângulo: ");

            double areaRetangulo = baseRetangulo * alturaRetangulo;
            Console.WriteLine($"A área do retângulo é de: {areaRetangulo}");
            Validacao.AguardarTecla();
        }

        // 15 Criar um programa que calcule e apresenta na tela a área de um triângulo. Fórmula: area = base.altura /2
        public static void Ex15()
        {
            double baseTriangulo = Validacao.ValidarNumeroDouble("Informe a altura (h) do triângulo: ");
            double alturaTriangulo = Validacao.ValidarNumeroDouble("Informe a base (b) triângulo: ");

            double areaTriangulo = baseTriangulo * alturaTriangulo / 2;
            Console.WriteLine($"A área do retângulo é de: {areaTriangulo}");
            Validacao.AguardarTecla();
        }

        //16 Criar um algoritmo que calcule e apresente na tela o volume de uma esfera de raio R, em que R é um dado fornecido pelo usuário. O volume de uma esfera é dado por V= 4/3 ​π R*3.
        public static void Ex16()
        {
            double r = Validacao.ValidarNumero("Informe o raio da esfera: ");

            double volumeEsfera = 4 * Math.PI * Math.Pow(r, 3) / 3;
            Console.WriteLine($"O volume da esfera de raio {r} é: {volumeEsfera:F2}");
        }

        //17 Criar um algoritmo que calcule e apresente na tela a área de um trapézio. Fórmula: A=((basemaior+basemenor)∗altura)/2
        public static void Ex17()
        {
            double baseMaior = Validacao.ValidarNumeroDouble("Informe a base maior(B) do trapézio: ");
            double baseMenor = Validacao.ValidarNumeroDouble("Informe a base menor(b) do trapézio: ");
            double altura = Validacao.ValidarNumeroDouble("Informe a altura(h) trapézio: ");

            double area = (baseMaior + baseMenor) * altura / 2;
            Console.WriteLine($"A área do trapézio é: {area}");
            Validacao.AguardarTecla();
        }

        //18 Criar um algoritmo que calcule e apresente na tela o volume de uma caixa retangular, utilizando a fórmula: volume=comprimento∗largura∗altura.
        public static void Ex18()
        {
            double comprimento = Validacao.ValidarNumero("Informe o comprimento da caixa retangular: ");
            double largura = Validacao.ValidarNumero("Informe a largura da caixa retangular: ");
            double altura = Validacao.ValidarNumero("Informe a altura da caixa retangular: ");

            double volume = comprimento * largura * altura;

            Console.WriteLine($"O volume da caixa retangular é de {volume} cm3");
            Validacao.AguardarTecla();
        }

        //19 Criar um algoritmo que lê dois números, a base e o expoente, e imprime a potência (base elevada ao expoente). 
        //Dica: use a função matemática ​Math.pow()​. Exemplo: 5 elevado ao cubo ficaria Math.pow(5, 3) ​. Você pode trocar esses números por variáveis.
        public static void Ex19()
        {
            double num1 = Validacao.ValidarNumeroDouble("Informe a base: ");
            double num2 = Validacao.ValidarNumeroDouble("Informe o expoente: ");

            double potencia = Math.Pow(num1, num2);
            Console.WriteLine($"A potência é: {potencia} ");
            Validacao.AguardarTecla();
        }

        // 20 Criar um algoritmo que lê dois números e imprime a soma dos quadrados dos dois números. O quadrado de um número A é representado por A² = A * A.
        public static void Ex20()
        {
            double num1 = Validacao.ValidarNumero("Informe um número: ");
            double num2 = Validacao.ValidarNumero("Informe outro número: ");

            double quadradoNum1 = Math.Pow(num1, 2);
            double quadradoNum2 = Math.Pow(num2, 2);

            double somaQuadrado = quadradoNum1 + quadradoNum2;

            Console.WriteLine($"A soma dos quadrados de {num1} e {num2} é: {somaQuadrado}");
        }

        //21 Criar um algoritmo que apresenta o valor da conversão em real (R$) de um valor lido em dólar (US$). 
        //O algoritmo deve solicitar o valor da cotação do dólar e também a quantidade de dólares disponível com o usuário.
        public static void Ex21()
        {
            double cotacaoDolar = Validacao.ValidarNumeroDouble("Informe a cotação do dólar: ");
            double quantidadeDolar = Validacao.ValidarNumeroDouble("Informe a quantidade de dólares: ");

            double conversaoReais = cotacaoDolar * quantidadeDolar;
            Console.WriteLine($"{conversaoReais:F2}");
        }

        //22 Criar um algoritmo que leia três valores inteiros e apresente na tela o valor da soma dos quadrados dos três valores lidos.
        public static void Ex22()
        {
            double num1 = Validacao.ValidarNumero("Informe o primeiro número inteiro: ");
            double num2 = Validacao.ValidarNumero("Informe o segundo número inteiro: ");
            double num3 = Validacao.ValidarNumero("Informe o terceiro número inteiro: ");

            double quadradoNum1 = Math.Pow(num1, 2);
            double quadradoNum2 = Math.Pow(num2, 2);
            double quadradoNum3 = Math.Pow(num3, 2);

            double somaQuadrado = quadradoNum1 + quadradoNum2 + quadradoNum3;

            Console.WriteLine($"A soma dos quadrados de {num1}, {num2} e {num3} é: {somaQuadrado}");
            Validacao.AguardarTecla();
        }

        //23 Criar um algoritmo que leia três valores inteiros e apresente na tela o valor do quadrado da soma dos três números lidos.
        public static void Ex23()
        {
            int num1 = Validacao.ValidarNumero("Informe o primeiro número inteiro: ");
            int num2 = Validacao.ValidarNumero("Informe o segundo número inteiro: ");
            int num3 = Validacao.ValidarNumero("Informe o terceiro número inteiro: ");

            int soma = num1 + num2 + num3;
            int quadradoSoma = soma * soma;

            Console.WriteLine($"O quadrado da soma de {num1}, {num2} e {num3} é: {quadradoSoma}");
            Validacao.AguardarTecla();
        }

        //24 Criar um algoritmo que leia os dias letivos de uma instituição qualquer, calcule e apresenta na tela a quantidade máxima de faltas que um aluno pode possuir. 
        //Um aluno pode faltar até 25% dos dias letivos.
        public static void Ex24()
        {
            int diasLetivos = Validacao.ValidarNumero("Informe os dias letivos de sua escola: ");

            int faltas = diasLetivos * 25 / 100;
            Console.WriteLine($"Você pode ter no maximo {faltas} faltas durante o ano letivo.");
            Validacao.AguardarTecla();
        }

        //25 Criar um algoritmo que leia o valor correspondente ao salário mensal de um trabalhador e também o valor do percentual de reajuste a ser atribuído ao salário. Apresente na tela o valor do novo salário.
        public static void Ex25()
        {
            double salario = Validacao.ValidarNumeroDouble("Informe seu salário: ");
            double reajuste = Validacao.ValidarNumeroDouble("Informe em quantos % seu salário foi reajustado: ");

            double salarioReajustado = salario * reajuste / 100;
            double novoSalario = salario + salarioReajustado;

            Console.WriteLine($"Você teve o reajuste de R$ {salarioReajustado} eu novo salário é R${novoSalario}");

        }

        //26 Criar um algoritmo que leia a metragem (altura e base) de um muro e o valor do metro quadrado cobrado pelo pedreiro, calcule e apresente na tela o custo da mão-de-obra para levantá-lo.
        public static void Ex26()
        {
            double altura = Validacao.ValidarNumeroDouble("Informe a altura do muro: ");
            double largura = Validacao.ValidarNumeroDouble("Informe a largura do muro: ");
            double valorMetro = Validacao.ValidarNumeroDouble("Informe o valor cobrado por m²: ");

            double metroQuadrado = altura * largura;
            double maoDeObra = metroQuadrado * valorMetro;
            Console.WriteLine($"O custo será de {maoDeObra:C}");
            Validacao.AguardarTecla();
        }

        //27 Sabe-se que 1m² de carpete custa R$ 35,00. Criar um algoritmo que leia o comprimento e a largura de uma sala, em metros, calcule e apresente na tela o valor que será gasto para forrar todo o seu piso.
        public static void Ex27()
        {
            double comprimento = Validacao.ValidarNumeroDouble("Informe o comprimento da sala em metros: ");
            double largura = Validacao.ValidarNumeroDouble("Informe a largura da sala em metros: ");

            // Calcula a área da sala em metros quadrados
            double areaSala = comprimento * largura;

            // Calcula o custo total para forrar o piso
            double custoTotal = areaSala * 35.00;

            Console.WriteLine($"O valor total para forrar o piso da sala é: {custoTotal:C}");
            Validacao.AguardarTecla();
        }

        //28 O custo ao consumidor, de um carro novo, é a soma do custo de fábrica com a porcentagem do distribuidor e dos impostos (aplicados ao custo de fábrica). 
        //Supondo que a porcentagem do distribuidor seja de 28% e os impostos de 45%, criar um algoritmo que leia o custo de fábrica de um carro e apresenta na tela o custo final ao consumidor.
        public static void Ex28()
        {
            double custoFabrica = Validacao.ValidarNumeroDouble("Informe o valor do veículo de fábrica R$: ");

            double distribuidor = custoFabrica * 28 / 100;
            double imposto = custoFabrica * 45 / 100;

            double custoFinal = custoFabrica + distribuidor + imposto;
            Console.WriteLine($"O valor final do veículo é de {custoFinal:C}");
            Validacao.AguardarTecla();
        }

        //29 Uma revendedora de carros usados paga a seus funcionários vendedores, um salário fixo por mês, mais uma comissão em reais também fixa para cada carro vendido e mais 5% do valor das vendas por ele efetuadas. 
        //Criar um algoritmo que leia o número de carros por ele vendidos, o valor total de suas vendas, o salário fixo e o valor que recebe por carro vendido, calcule e apresente na tela o salário mensal do vendedor.
        public static void Ex29()
        {
            int carrosVendidos = Validacao.ValidarNumero("Informe o número de carros vendidos: ");
            double valorTotalVenda = Validacao.ValidarNumeroDouble("Informe o valor total de suas vendas: ");
            double salarioFixo = Validacao.ValidarNumeroDouble("Informe seu salário fixo por mês: ");
            double comissaoPorCarroVendido = Validacao.ValidarNumeroDouble("Informe o valor da sua comissão por carro vendido: ");

            double comissao = carrosVendidos * comissaoPorCarroVendido;
            double porcentagem = valorTotalVenda * 5 / 100;

            double salarioTotal = comissao + porcentagem + salarioFixo;
            Console.WriteLine($"Seu salário total é de: {salarioTotal:C}");
            Validacao.AguardarTecla();
        }

        /* 30  Uma conta telefônica é composta dos seguintes custos: 
        Assinatura ==> R$ 17,90; Minutos Chamada Local ==> R$ 0,04 por minuto; Minutos Chamada Celular ==> R$0,20 por minuto; Interurbanos.
         Criar um algoritmo que calcule o valor total a ser pago sabendo será fornecida a quantidade de impulsos e de chamadas para celular. 
        O valor gasto em interurbanos foi de R$ 34,29. Apresentar na tela os custos e o valor total a ser pago.*/
        public static void Ex30()
        {
            double Assinatura = 17.90;
            double CustoMinutoLocal = 0.04;
            double CustoMinutoCelular = 0.20;
            double CustoInterurbanos = 34.29;

            double impulsos = Validacao.ValidarNumeroDouble("Informe a quantidade de impulsos: ");
            double chamadasCelular = Validacao.ValidarNumeroDouble("Informe a quantidade de impulsos: ");

            double custoAssinatura = Assinatura;
            double custoChamadasLocais = impulsos * CustoMinutoLocal;
            double custoChamadasCelular = chamadasCelular * CustoMinutoCelular;
            double valorTotal = custoAssinatura + custoChamadasLocais + custoChamadasCelular + CustoInterurbanos;

            Console.WriteLine($"Custo da assinatura: R$ {custoAssinatura:F2}");
            Console.WriteLine($"Custo das chamadas locais: R$ {custoChamadasLocais:F2}");
            Console.WriteLine($"Custo das chamadas para celular: R$ {custoChamadasCelular:F2}");
            Console.WriteLine($"Custo dos interurbanos: R$ {CustoInterurbanos:F2}");
            Console.WriteLine($"Valor total a ser pago: R$ {valorTotal:F2}");
            Validacao.AguardarTecla();
        }



    }
}