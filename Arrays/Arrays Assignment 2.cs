using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             Arrays Exercise

Write a program that first asks the user if they want to store numbers or words in an array. 
If the user selects words then the array should hold double values. If the user selects words then the array should hold string values.
Then the program asks the user how many items they want to store in the array. The array must be the same size as the number of items the user said they want to store.

Then ask the user for each item one by one and store it in the array.
When all items have been input by the user and stored in the array then show the user each index number and the item stored at each index of the array. 

 Extra: Show the user either the sum of the numbers in the array of the concatenation of the words in the array. */

            Console.Write("Store numbers press 'n'\nStore words press 'w'\nfollowed by the ENTER key: ");
            string choice = Console.ReadLine();

            if (choice == "n")
            {
                Console.WriteLine("***Enter Numbers***");
                Console.Write("How many numbers do you want to store? ");
                int array_length = int.Parse(Console.ReadLine());
                Console.WriteLine(array_length);

                double[] numbers = new double[array_length];

                for(int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"Enter number {i + 1}: ");
                    numbers[i] = double.Parse(Console.ReadLine());
                }

            double sum = 0;
            Console.WriteLine("Content of numbers array: ");
            for(int)

            }
            else if (choice == "w")
            {
                Console.WriteLine("***Enter Words***");

                for (int i = 0; i < words.Length; i++)
                {
                    Console.Write($"Enter word {i + 1}: ");
                    words[i] = double.Parse(Console.ReadLine());
                }



            }




            else
            {
                Console.WriteLine("Invalid choice");
            }

            Console.WriteLine("PRESS ENTER TO EXIT");
            Console.ReadLine();

            /* Console.Write("Store numbers press 'n'\nStore words press 'w'\nFollowed by the ENTER key: ");
            string choice = Console.ReadLine();

            if (choice == "n")
            {
                Console.WriteLine("\n***Enter numbers***\n");
                Console.Write("How many numbers do you want to store? ");
                int array_length = int.Parse(Console.ReadLine());
                Console.WriteLine(array_length);

                double[] numbers = new double[array_length];

                for(int i = 0; i < numbers.Length; i++) // 0,1,2 -> 1,2,3
                {
                    Console.Write($"Enter number {i+1}: ");
                    numbers[i] = double.Parse(Console.ReadLine());
                }

                double sum = 0;
                Console.WriteLine("Content of numbers array:");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine($"\tNumber at index {i}: {numbers[i]}");
                    sum = sum + numbers[i];
                }
                Console.WriteLine($"\tThe sum of the number in the array is: {sum}");


            }
            else if (choice == "w")
            {
                Console.WriteLine("\n***Enter words***\n");
                
                Console.Write("How many words do you want to store? ");
                int array_length = int.Parse(Console.ReadLine());
                Console.WriteLine(array_length);

                string[] words = new string[array_length];

                for (int i = 0; i < words.Length; i++) // 0,1,2 -> 1,2,3
                {
                    Console.Write($"Enter word {i + 1}: ");
                    words[i] = Console.ReadLine();
                }

                string allwords = "";

                Console.WriteLine("Content of numbers array:");
                for (int i = 0; i < words.Length; i++)
                {
                    Console.WriteLine($"\tWord at index {i}: {words[i]}");
                    allwords = allwords  + words[i];
                }
                Console.WriteLine($"\tThe concatenation of all the words in the array is:\n\t\t{allwords}");

            }
            else
            {
                Console.WriteLine("Invalid choice");
            }

            Console.WriteLine("ENTER TO EXIT");
            Console.ReadLine();*/


        }
    }
}
