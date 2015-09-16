using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Welcome_to_C_Sharp
{
    public class Program
    {
        private static string Name;//Persons name

        public static void Main(string[] args)
        {
           
            Console.Write("Enter your name:");
            Name = Console.ReadLine();// gets your name from the keyboard

            Console.WriteLine("Hello, " + Name + " Welcome to C# Programming!"); //writes a string and your name from Name var
            Dino();//Calls Dino
        }
        public static void Dino()
        {
            string Cool;//Dinosaurs!
            Console.Write("I  have a follow up question for you " + Name + " Do you like Dinosaurs?");// prints the string and your name
            Cool = Console.ReadLine();
            if (Cool == "yes")
            {
                Console.WriteLine("You are the most awesome person ever!");// type yes!
                Console.ReadKey();
            }

            else if (Cool == "no")
            {
                Console.WriteLine("You want to go home and rethink your life.");// this is what happens when you don't like dinos
                Dino();//recalls Dino 
            }

            else
            {
                Console.WriteLine("What you entered is not supported. Please try yes or no.");// i'm lost try again
                Dino();//recalls Dino 
            }
        }


    }
}

