using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criando um loop de quando o usuario escolher a opção (Ligar) seguir com aplicação 
            //(Desligar) que encerra a calculadora

            string desligar = "1";

            Console.Write("Calculadora");
            Console.WriteLine();
            Console.WriteLine("Para ligar digite '1':");
            string ligar = Console.ReadLine();
            if (ligar.Equals("1"))
            {
                while (true)
                {

                    Console.Write("Entre com um número: ");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.Write("Entre com operador: ");
                    string operador = Console.ReadLine();

                    Console.WriteLine("Entre com o segundo número: ");
                    int num2 = int.Parse(Console.ReadLine());

                    switch (operador)
                    {
                        case "+":
                            Console.WriteLine($"Resultado: {Somar(num1, num2)}");
                            break;

                        case "-":
                            Console.WriteLine($"Resultado: {Subtrair(num1, num2)}");
                            break;

                        case "*":
                            Console.WriteLine($"Resultado: {Multiplicar(num1, num2)}");
                            break;

                        case "/":
                            Console.WriteLine($"Resultado:  {Dividir(num1, num2)}");
                            break;
                    }
                    Console.WriteLine("Para continuar digite (2) para Encerrar digite (0)");
                    desligar = Console.ReadLine();
                    if (desligar == "0")
                    {
                        break;
                    }
                }
                
            }

        }
        public static string Somar(int num1, int num2)
        {
            return (num1 + num2).ToString();
        }
        public static string Subtrair(int num1, int num2)
        {
            return (num1 - num2).ToString();
        }
        public static string Multiplicar(int num1, int num2)
        {
            return (num1 * num2).ToString();
        }

        //METODO
        public static string Dividir(int num1, int num2)
        {
            if (valorDividendoMenorOuIgualZero(num2))
            {
                return "Não é possivel dividir por zero ou menor que zero";
            }

            return (num1 / num2).ToString();

            //FUNCAO
            bool valorDividendoMenorOuIgualZero(int num2)
            {
                if (num2 <= 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
