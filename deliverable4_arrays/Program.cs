/*
 * Kyle Kettles
 * 02/09/23
 * Code demonstrates arrays after getting input from users.
*/


using System;

namespace deliverable4_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter an integer 5 - 20");

            int input = int.Parse(Console.ReadLine());

            if ( input >= 5 && input <= 20 )
            {
                int[] even = new int[input];
                int[] odd = new int[input];
                int[] fibonacci= new int[input];

                //Start Fibonacci sequence
                fibonacci[0] = 0;
                fibonacci[1] = 1;

                for (int i = 0; i < input; i++)
                {
                    even[i] = 2*i;
                    odd[i] = 2*i+1;

                    if (i >= 2) 
                    {
                        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                    }
                    
                }
                Console.WriteLine("");
                Console.WriteLine("Even");
                foreach (int number in even)
                {
                    Console.WriteLine(number);
                }

                Console.WriteLine("");
                Console.WriteLine("Fibonacci");
                foreach (int number in fibonacci)
                { Console.WriteLine(number); }

                Console.WriteLine("");
                Console.WriteLine("Odd");
                foreach (int number in odd)
                { Console.WriteLine(number); }

                for (int i = 0; i < input; i++)
                {
                    Console.WriteLine("Fibonacci(" + i + ") = " + fibonacci[1]);
                }








            }







        }
    }
}