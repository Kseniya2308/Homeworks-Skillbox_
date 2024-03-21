using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace ДЗ_3._2
{
    internal class Program
    {
        static void Main()
        {


            Console.WriteLine("Добро пожаловать в игру 21! Подскажитие, сколько у вас карт?");
            int cardsCount = byte.Parse(Console.ReadLine());
            int score = 0;

            for (int i = 1; i <= cardsCount; i++)
            {
                Console.WriteLine($"Введите номинал {i} карты:");
                string card = (Console.ReadLine());


                switch (card)
                {
                    case "J":
                    case "Q":
                    case "K":
                    case "T":

                        score += 10;

                        break;
                    default:

                        score += int.Parse(card);
                        break;
                }


            }


            Console.WriteLine($"Вы набрали - {score}");


        }
    }


}
