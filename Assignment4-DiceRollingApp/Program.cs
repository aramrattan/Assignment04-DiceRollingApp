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
            Random rnd = new Random();
            int firstDie = 0;
            int secondDie = 0;
            int sum;
            int[] sumArray = new int[10];
            //Check to see if the array adds properlly
            int sumOf2=0, sumOf3=0, sumOf4=0, sumOf5=0, sumOf6=0, sumOf7=0, sumOf8=0, sumOf9=0, sumOf10=0, sumOf11=0, sumOf12=0;

            for (int i = 0; i < 36000; i++)
			{
			 
            firstDie = rnd.Next(1, 7);
            secondDie = rnd.Next(1, 7);
            sum = firstDie + secondDie;
            Console.WriteLine("{0} {1} {2}", firstDie, secondDie, sum);
            switch (sum)
            {
                case 2:
                    sumOf2++;
                    sumArray[0]++;
                    break;

                case 3:
                    sumArray[1]++;
                    sumOf3++;
                    break;
                case 4:
                    sumArray[2]++;
                    sumOf4++;
                    break;
                case 5:
                    sumArray[3]++;
                    sumOf5++;
                    break;
                case 6:
                    sumArray[4]++;
                    sumOf6++;
                    break;
                case 7:
                    sumArray[5]++;
                    sumOf7++;
                    break;
                case 8:
                    sumArray[6]++;
                    sumOf8++;
                    break;
                case 9:
                    sumArray[7]++;
                    sumOf9++;
                    break;
                case 10:
                    sumArray[8]++;
                    sumOf10++;
                    break;
                case 11:
                    sumArray[9]++;
                    sumOf11++;
                    break;
                case 12:
                    sumArray[10]++;
                    sumOf12++;
                    break;
            }


            }




        }
    }
}
