//Gabriel James
//Mission 2
//This program simulates the rolling of two dice and shows the percentages of each total number rolled
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare all variables that i will be using 
            int[] totals = new int[13]; 
            int numThrows;
            const int mult = 100;
            double perc = 0;
            Random rnd = new Random();

            // welcome the user and ask how many rolls they would like to simulate
            //I then had to parse the input because it is an integer input
            Console.WriteLine("Welcome to the dice throwing simulator!");

            Console.WriteLine("How many dice rolls would you like to simulate? (Please input an integer)");
            numThrows = int.Parse(Console.ReadLine());

            //this is the loop that i will use to roll the die
            //i loop through this the amount of times that the user inputs at the start and then I add the totals to the total array
            for (int i = 0; i < numThrows; i++)
            {
                int die1 = rnd.Next(1, 7); 
                int die2 = rnd.Next(1, 7); 
                int total = die1 + die2; 
                totals[total]++;
            }

            //here I begin to output the results from the program

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each * represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numThrows);

            Console.WriteLine("Total Percentage of Throws for Each Number:");
            //I also inlcuded the percentages after the aterix just so that it made it more legible for the user
            for (int i = 2; i <= 12; i++)
            {
                perc = Math.Round((double)totals[i] / numThrows * mult); 
                Console.Write(i + ": ");
                for (int j = 0; j < perc; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" " + perc + "%");
            }


            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

            // this last readline was so that the window would stay open until the user hit enter
            //this was the best way that i could figure out to be able to keep the outputs on the screen for as long as the user wanted.
            Console.ReadLine();
        }
}
}
