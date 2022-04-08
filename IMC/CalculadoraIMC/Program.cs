using System;
using System.Globalization;

namespace CalculadoraIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name;
            int age;
            double Weight;
            double Height;
            double Imc;


            Console.WriteLine("Digite seu nome: ");
            Name = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Olá {Name} Digite seu peso: ");
            Weight = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Olá {Name} Digite sua altura: ");
            Height = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Imc = Weight / (Height * Height);

            if (Imc < 18.5)
            {

                Console.WriteLine($"Olá {Name} Sua massa muscular encontra-se na faixa: Abaixo do peso ");

            }
            else if (Imc < 25)
            {

                Console.WriteLine($"Olá {Name} Sua massa muscular encontra-se na faixa: Peso Normal ");
            }
            else if (Imc < 30)
            {

                Console.WriteLine($"Olá {Name} Sua massa muscular encontra-se na faixa: Sobrepeso ");

            }
            else
            {
                Console.WriteLine($"Olá {Name} Sua massa muscular encontra-se na faixa: Obesidade ");
            }
        }
    }
}
