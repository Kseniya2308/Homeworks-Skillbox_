namespace _3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину последовательности:");
            int length = Convert.ToInt32(Console.ReadLine());

            int min = int.MaxValue;

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Введите {i + 1}-е число: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num < min)
                {
                    min = num;
                }
            }

            Console.WriteLine($"Наименьшее число в последовательности: {min}");
        }
    }
    }

