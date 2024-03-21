using System.ComponentModel.Design;

namespace Домашняя_работа_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
                
            Console.WriteLine("Введите число:  ");

            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} - четное число");
            }
            else 
            { 
                Console.WriteLine($"{number} - нечетное число"); 
            }

                
        }
    }
}
