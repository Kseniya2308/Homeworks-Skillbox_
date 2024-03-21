using System.ComponentModel.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ДЗ_3._3
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите целое число: ");
            int N = Convert.ToInt32(Console.ReadLine());

            bool result = true;

            int i = 2;
            while (i < N)
            {
                if (N % i == 0)
                {
                    result = false;
                    break;
                }

                i++;
            }

            if (result)
            {
                Console.WriteLine("Введенное число является простым.");
            }
            else
            {
                Console.WriteLine("Введенное число не является простым.");
            }
        }



    }
      
        }



            

           
        

        
       


     
    


