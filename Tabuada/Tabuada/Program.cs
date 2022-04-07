using System;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite qual tabuada deseja visualizar : ");
            int InputNum = Convert.ToInt32(Console.ReadLine());
            tab(InputNum);
        }
        public static void tab(int num)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i} ");
            }
        }
    }
}
