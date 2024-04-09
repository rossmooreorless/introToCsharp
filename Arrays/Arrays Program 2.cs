using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char myChar = 'A';

            //Console.WriteLine(myChar);
            //// cast/convert the char to an int
            //Console.WriteLine((int)myChar);

            //Console.WriteLine((int)'B');

            //Console.WriteLine((char)55);

            //Console.WriteLine("Enter how many times you want to loop: ");

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(myChar);
            //    myChar++;
            //}

            //string s1 = "Some text";

            //Console.WriteLine($"The first char in s1 is '{s1[0]}'");

            //// Get all of the characters in a string as an array of chars?

            //char[] myCharsArray = { 'B', 'r', 'e', 'a', 'k' };

            //Console.WriteLine(myCharsArray);

            //string myCharAsString1 = new string(myCharsArray);

            //Console.WriteLine(myCharAsString1);

            //string myCharsAsString2 = string.Join("-|-", myCharsArray);
            //Console.WriteLine(myCharsAsString2);

            //Console.WriteLine("Converting a to an array of characters");

            //string sentence = "Mary had a little lamb";

            //char[] sentenceCharsArray = sentence.ToCharArray();

            //foreach (char character in sentenceCharsArray)
            //{
            //    Console.WriteLine(character);
            //}

            //Console.ReadLine();

            bool run = true;

            string[] animals = new string[] { "dog", "cat", "rabbit", "hamster", "guinea pig", "parrot", "goldfish", "turtle",
                "chicken", "duck", "goose", "turkey", "pig", "sheep", "cow", "horse", "donkey", "elephant", "lion", "tiger",
                "giraffe", "hippopotamus", "rhinoceros", "monkey", "gorilla", "koala", "kangaroo", "crocodile", "snake", "spider" };

            while (run) 
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1) Add Numbers");
                Console.WriteLine("2) Search for an item in array");
                Console.WriteLine("3) Reverse a string");
                Console.WriteLine("e) Exit");
                Console.Write("Option: ");
                string option = Console.ReadLine().Trim().ToLower();

                switch (option)
                {
                    case "1":
                        // to do
                        // ask the user how many numbers they want to enter?
                        // get each number from the user
                        // show them the sum of those numbers
                        break;
                    case "2":
                        // to do
                        // Show the user a numbered list of all the animal names in the array of animals.
                        // Then ask the user what animal they want to search for.
                        // Note: Case should be ignored in the search
                        // Tell the user if that animal name is in the list or not.
                        break;
                    case "3":
                        // To do
                        // Ask the user for a string and then show them the reverse of that string
                        // Don't use a built in method!!
                        Console.WriteLine("Enter some text: ");
                        string text = Console.ReadLine();
                        // one way could... make array or chars from the string and use a loop to get a reversed version
                        
                        char[] textCharArray = text.ToCharArray(); // ['M', 'a', 'r', 'y' ] -> Length of 4, indexes 0,1,2,3

                        // Array to hold the same number or chars as the textCharArray
                        char[] reverseTextChars = new char[textCharArray.Length];

                        int lastIndexOfTextCharsArray = textCharArray.Length - 1; // Last index in array ->
                        for (int i = 0; i < textCharArray.Length; i++)
                        {
                            reverseTextChars[lastIndexOfTextCharsArray] = textCharArray[i];
                            lastIndexOfTextCharsArray--; // 3,2,1,0
                        }

                        string reverseText = new string(reverseTextChars);

                        Console.WriteLine(reverseTextChars);

                        break;
                    case "e":
                        Console.WriteLine("Bye, Bye");
                        // Pause the execution of our code for 2000 milliseconds (2 seconds)
                        System.Threading.Thread.Sleep(2000);
                        Environment.Exit(0);
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Option!");
                        break;
                } // end of switch statement 

            } // end of while loop




            Console.ReadLine();
        } // end of main
    }
}
