namespace _3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.Write("Введите максимальное целое число диапазона: ");
            int maxNumber = int.Parse(Console.ReadLine());

            int secretNumber = random.Next(0, maxNumber + 1);
            int guess = -1;

            Console.WriteLine("Программа задумала число от 0 до " + maxNumber);

            while (guess != secretNumber)
            {
                Console.Write("Угадайте число: ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Вы не угадали. Загаданное число было: " + secretNumber);
                    break;
                }

                guess = int.Parse(input);

                if (guess < secretNumber)
                {
                    Console.WriteLine("Загаданное число больше.");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Загаданное число меньше.");
                }
                else
                {
                    Console.WriteLine("Поздравляем! Вы угадали число: " + secretNumber);
                }
            }
        }
    }
}
