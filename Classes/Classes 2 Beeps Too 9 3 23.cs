using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Ford";
            car1.Model = "Focus";
            car1.Color = "Pink";
            car1.Milage = 97003;

            Car car2 = new Car()
            { 
                    Color = "Green",
                    Make = "Nissan",
                    Model = "Sunny",
                    Milage = 209134};

            Console.WriteLine($"{car1.Make} {car1.Model} in {car1.Color} with milage {car1.Milage}");

            car1.DriveForward();
            car2.DriveForward();    

            car1.Reverse();
            car2.Reverse();

            car1.BeepBeep();
            car2.BeepBeep();    

            Console.ReadLine();
        }
    }

    class Car 
    {
        //public string make;

        // each car object will have these properties

        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Milage { get; set; }

        // Behaviours 
        // instance method

        public void DriveForward()
        {
            Console.WriteLine($"The {Make} {Model}  is driving forward");
        }

        public void Reverse() 
        {
            Console.WriteLine($"The {Color} {Make} {Model} is reversing"); 
        }

        // Make a method that makes the car beep

        public void BeepBeep(int numOfBeeps=1)
        {
            Console.WriteLine($"The {Make} {Model}, the {Color} one is beeping like crazy!");

            for (int i = 0; i < numOfBeeps; i++) 
            {
                Console.Write("Beep!! ");
                Console.Beep(750, 950); // hz's and millisecond
            }

            Console.WriteLine();
        }



    }




}


// Thursday 9/3/2023 - Learning classes and beeps