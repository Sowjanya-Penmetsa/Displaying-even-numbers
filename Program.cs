using System;

namespace Display_Even
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Numbers = new int[10];
            int i;

            Console.WriteLine("Enter 10 numbers ");

            //Reading the numbers into the array

            for (i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = int.Parse(Console.ReadLine());
            }

            // Displaying the numbers in the array

            Console.WriteLine("The numbers in the array are:");
            for(i = 0; i < Numbers.Length; i++)
            Console.WriteLine(Numbers[i]);

            //Displaying the even numbers in the array

            Console.WriteLine("Following are the even numbers ");
            for(i=0;i<Numbers.Length;i++)
            {
                if (Numbers[i] % 2 == 0)
                    Console.WriteLine(Numbers[i]);
            }
            Console.ReadLine();
        }

    }
}
