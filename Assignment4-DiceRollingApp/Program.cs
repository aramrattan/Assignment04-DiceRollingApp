using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_DiceRollingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //varibles needed
            Random rnd = new Random();
            int firstDie = 0;
            int secondDie = 0;
            int sum;
            int[] sumArray = new int[11];

            //for loop to roll the dice 36000 times
            for (int i = 0; i < 36000; i++)
            {

                firstDie = rnd.Next(1, 7);
                secondDie = rnd.Next(1, 7);
                sum = firstDie + secondDie;

                //switch statement to add up how many times each value is achieved
                switch (sum)
                {
                    case 2:
                        sumArray[0]++;
                        break;

                    case 3:
                        sumArray[1]++;
                        break;
                    case 4:
                        sumArray[2]++;
                        break;
                    case 5:
                        sumArray[3]++;
                        break;
                    case 6:
                        sumArray[4]++;
                        break;
                    case 7:
                        sumArray[5]++;
                        break;
                    case 8:
                        sumArray[6]++;
                        break;
                    case 9:
                        sumArray[7]++;
                        break;
                    case 10:
                        sumArray[8]++;
                        break;
                    case 11:
                        sumArray[9]++;
                        break;
                    case 12:
                        sumArray[10]++;
                        break;
                }


            }
            //Displaying of the sums
            Console.WriteLine();
            Console.WriteLine("***********************************");
            Console.WriteLine("****         TOTAL SUMS        ****");
            Console.WriteLine("***********************************");
            Console.WriteLine();

            //For loop to go through each index in the array and display its value
            for (int index = 0; index < sumArray.Length; index++)
            {
                Console.WriteLine("** {0}: {1} ", index + 2, sumArray[index]);
            }

            WaitForKey();


        }


        private static void WaitForKey()
        {
            Console.WriteLine();
            Console.WriteLine("***********************************");
            Console.WriteLine("Press any key to continue...");
            Console.WriteLine("***********************************");
            Console.ReadKey();
            
        }
    }
}
