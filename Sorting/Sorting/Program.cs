using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The sorting hat");

            Random rnd = new Random();

            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = rnd.Next(1, 100);
                Console.Write(numbers[i] + " ");
            }

            bool swapped = true;

            while (swapped == true)
            {
                swapped = false;
                for (int i = 1; i < 10; i++)
                {
                    if (numbers[i - 1] > numbers[i]) {
                        int temp = numbers[i];
                        numbers[i] = numbers[i - 1];
                        numbers[i - 1] = temp;
                        swapped = true;
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                
                Console.Write(numbers[i] + " ");
            }

            Console.Read();
        }
    }
}
