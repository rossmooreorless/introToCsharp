using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysProgram1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            string[] animals = new string[] { "dog", "cat", "rabbit", "hamster", "guinea pig", "parrot",
                "goldfish", "turtle", "chicken", "duck", "goose", "turkey", "pig", "sheep", "cow", "horse", "donkey",
                "elephant", "lion", "tiger", "giraffe", "hippopotamus", "rhinoceros", "monkey", "gorilla", "koala",
                "kangaroo", "crocodile", "snake", "spider" };


            while (run)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1) Add Numbers");
                Console.WriteLine("2) Search for animal name in list.");
                Console.WriteLine("3) Reverse a string");
                Console.WriteLine("e) Exit");
                Console.Write("Option: ");
                string option = Console.ReadLine().Trim().ToLower();

                switch (option)
                {
                    case "1":
                        // to do
                        // Ask the user how many numbers they want to enter?
                        Console.Write("How many number do you want to enter? ");
                        int numOfNums = int.Parse(Console.ReadLine());

                        double[] numbers = GetDoubleArray(numOfNums);

                        double sum = AddNumbers(numbers);

                        Console.WriteLine($"The sum of those numbers is: {sum}");

                        // Get each number from the user
                        // Show the user the sum of those numbers
                        break;
                    case "2":

                    // to do
                    // Show the user a numbered list of all the animal names in the array of animals.
                    // Then ask the user what anaiml they want to search for.

                    /* case "2":
                        // to do
                        // Show the user a numbered list of all the animal names in the array of animals.
                        for (int i = 0; i < animals.Length; i++)
                        {
                            // Console.WriteLine($"({i+1})\t:{animals[i]}");
                            // dog -> Dog, rabbit -> Rabbit
                            Console.WriteLine($"({(i + 1):00}):{animals[i].Substring(0, 1).ToUpper() + animals[i].Substring(1).ToLower()}");
                        }
                        // Then ask the user what anaiml they want to search for.

                        Console.Write("Search for animal name: ");
                        string search_animal = Console.ReadLine().Trim();

                        bool found = false;

                        // Note: Case should be ignored in the search
                        for (int i = 0; i < animals.Length; i++)
                        {
                            if (search_animal.ToLower() == animals[i].ToLower())
                            {
                                found = true;
                                break;
                            }

                        }

                        // Tell the user if that animal name is in the list or not.
                        if (found)
                        {
                            Console.WriteLine($"Found the animal named {search_animal} in the list!");
                        }
                        else
                        {
                            Console.WriteLine($"Animal named {search_animal} not found!");
                        }

                        break;


                        Console.Write("Search for animal name: ");
                        string search_animal = Console.ReadLine();

                        bool found = false;

                        for (int i = 0; i < animals.Length; i++)
                        {
                            if (search_animal == animals[i])
                            {
                                found = true;
                                break;
                            }
                        }

                        if (found)
                        {
                            Console.WriteLine($"Found the animal named {search_animal} in the list!");
                        }
                        else
                        {
                            Console.WriteLine($"Animal named {search_animal} not found!");
                        }

                        */


                        // Note: Case should be ignored in the search
                        // Tell the user if that animal name is in the list or not.
                        break;
                    case "3":
                        // to do
                        // Ask the user for a string and then show them the reverse of that string
                        // Don't use a built in method!!!
                        Console.WriteLine("Enter some text: ");
                        string text = Console.ReadLine();
                        //// One way could... make array of chars from the string an use a loop to get a reversed version

                        //char[] textCharArray = text.ToCharArray(); // ['M','a','r','y'] -> Length of 4, indexes 0,1,2,3

                        //// Array to hold the same number or chars as the texCharsArray
                        //char[] reverseTextChars = new char[textCharArray.Length]; // ['y','r','a','M']

                        //int lastIndexOfTextCharsArray = textCharArray.Length - 1; // Last index in array -> 3
                        //for (int i = 0; i < textCharArray.Length; i++)
                        //{
                        //    reverseTextChars[lastIndexOfTextCharsArray] = textCharArray[i]; // 0,1,2,3
                        //    lastIndexOfTextCharsArray--; // 3,2,1,0
                        //}
                        //string reverseText = new string(reverseTextChars);
                        //Console.WriteLine(reverseText);
                        
                        string reversedText = reverseString(text);

                        Console.WriteLine($"The reverse of that text is:\n{reversedText}");

                        break;
                    case "e":                        
                    case "exit":
                        Console.WriteLine("Bye Bye");
                        // Pause the execution of our code. 1000 milliseconds is 1 second
                        System.Threading.Thread.Sleep(2000);
                        // Environment.Exit(0);
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }// end of switch statement

            } // end of while loop
              
        } // end of Main

        static string reverseString(string text)
        {
            string reversed = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                // reversed = reversed + text[i];
                reversed += text[i];
            }
            return reversed;
        } // end of reverseString method

        static double AddNumbers(double[] nums)
        {
            double sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            return sum;
        }


        static double[] GetDoubleArray(int lengthOfDoubleArray)
        {
            double[] numbers = new double[lengthOfDoubleArray];

            for (int i = 0; i < lengthOfDoubleArray; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = double.Parse(Console.ReadLine());
            }
            return numbers;
        }

    } // end of Program class

} // end of Namespace
