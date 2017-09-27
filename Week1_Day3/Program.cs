using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Day3
{
    class Program
    {
        static void Main(string[] args)
        {

            /* int firstNumber = 6;
             int secondNumber = 2;

             if(firstNumber > secondNumber)
             {
                 Console.WriteLine("You have broken math");
             }

             {
                 Console.WriteLine("That makes sense");
             }*/

            {

                Console.WriteLine("what day is today?");
                string userAnswer = (Console.ReadLine);

                if (userAnswer == "Monday")
                            {

                                Console.WriteLine("Back to work");

                            }
           
                 else if (userAnswer == "Friday")

                            {
                                Console.WriteLine("TGIF!");
                            }
                else
                {
                    Console.WriteLine("Bloop!");


                }


            }

        }
    }
}