using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado = 0;
            int saida = 0;
            while(saida != 1)
            {
                Console.Clear();
                Console.Write("Digite o primeiro número: ");
                double numero1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                double numero2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n");
                Console.WriteLine("1 - ADIÇÃO");
                Console.WriteLine("2 - SUBTRAÇÃO");
                Console.WriteLine("3 - MULTIPLICAÇÃO");
                Console.WriteLine("4 - DIVISÃO");
                Console.WriteLine("5 - SAIR");

                Console.WriteLine("\n");

                Console.Write("Digite a operação desejada: ");
                int operacao = Convert.ToInt32(Console.ReadLine());
                switch (operacao)
                {
                    case 1:
                        resultado = numero1 + numero2;
                        operacao = 0;
                        Console.WriteLine($"O resultado da adição de {numero1} e {numero2} é {resultado}.");
                        Console.ReadLine();
                        break;
                    case 2:
                        resultado = numero1 - numero2;
                        operacao = 0;
                        Console.WriteLine($"Subtraindo {numero2} de {numero1} obtemos {resultado}.");
                        Console.ReadLine();
                        break;
                    case 3:
                        resultado = numero1 * numero2;
                        operacao = 0;
                        Console.WriteLine($"O resultado da multiplicação de {numero1} por {numero2} é {resultado}.");
                        Console.ReadLine();
                        break;
                    case 4:
                        resultado = (numero1 / numero2);
                        operacao = 0;
                        Console.WriteLine($"O resultado da divisão de {numero1} por {numero2} é {resultado:N2}.");
                        Console.ReadLine();
                        break;
                    case 5:
                        saida = 1;
                        break;
                    default:
                        Console.WriteLine("Operação Inválida!");
                        break;
                }
            } 
        }
    }
}