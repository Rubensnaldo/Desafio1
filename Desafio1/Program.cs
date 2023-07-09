using System;

class Calculadora
{
    static void Main(string[] args)
    {
        int opcao;

        do
        {
            MostrarMenu();
            opcao = LerOpcao();

            switch (opcao)
            {
                case 1:
                    Somar();
                    break;
                case 2:
                    Subtrair();
                    break;
                case 3:
                    Multiplicar();
                    break;
                case 4:
                    Dividir();
                    break;
                case 0:
                    Console.WriteLine("Saindo da calculadora...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine();
        } while (opcao != 0);
    }

    static void MostrarMenu()
    {
        Console.WriteLine("===== Calculadora =====");
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");
        Console.WriteLine("0 - Sair");
        Console.Write("Escolha uma opção: ");
    }

    static int LerOpcao()
    {
        int opcao;
        while (!int.TryParse(Console.ReadLine(), out opcao))
        {
            Console.WriteLine("Opção inválida. Tente novamente.");
            Console.Write("Escolha uma opção: ");
        }
        return opcao;
    }

    static void Somar()
    {
        Console.Write("Digite o primeiro valor: ");
        double valor1 = LerValor();

        Console.Write("Digite o segundo valor: ");
        double valor2 = LerValor();

        double resultado = valor1 + valor2;

        Console.WriteLine($"Resultado da soma: {resultado}");
    }

    static void Subtrair()
    {
        Console.Write("Digite o primeiro valor: ");
        double valor1 = LerValor();

        Console.Write("Digite o segundo valor: ");
        double valor2 = LerValor();

        double resultado = valor1 - valor2;

        Console.WriteLine($"Resultado da subtração: {resultado}");
    }

    static void Multiplicar()
    {
        Console.Write("Digite o primeiro valor: ");
        double valor1 = LerValor();

        Console.Write("Digite o segundo valor: ");
        double valor2 = LerValor();

        double resultado = valor1 * valor2;

        Console.WriteLine($"Resultado da multiplicação: {resultado}");
    }

    static void Dividir()
    {
        Console.Write("Digite o primeiro valor: ");
        double valor1 = LerValor();

        Console.Write("Digite o segundo valor: ");
        double valor2 = LerValor();

        if (valor2 != 0)
        {
            double resultado = valor1 / valor2;
            Console.WriteLine($"Resultado da divisão: {resultado}");
        }
        else
        {
            Console.WriteLine("Não é possível dividir por zero.");
        }
    }

    static double LerValor()
    {
        double valor;
        while (!double.TryParse(Console.ReadLine(), out valor))
        {
            Console.WriteLine("Valor inválido. Tente novamente.");
            Console.Write("Digite um valor válido: ");
        }
        return valor;
    }
}

