using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine(" Welcome to the Grand Circus Casino!");
            while (true)
            {
                Console.WriteLine(" How many sides does your dice have? Please put in the number!");
                int numberOfSide = int.Parse(Console.ReadLine());

               
                Console.WriteLine(" Please roll the dice!");
              int diceOne = RandomNumberGeneratorForDiceOne(numberOfSide); //invoking method
              int diceTwo =  RandomNumberGeneratorForDiceTwo(numberOfSide); // invoking method


                Console.WriteLine("{0}", diceOne); // printing the output 
                Console.WriteLine("{0}", diceTwo);
                Console.ReadKey();

                Console.WriteLine("Roll again?y/n");
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }
                
            }

        }   
        // method to generate random number for dice one
        public static int RandomNumberGeneratorForDiceOne (int numberOfSide)
        {
            int diceOne;
            Random rand1 = new Random(); // initializing the random class
            diceOne = rand1.Next(1, numberOfSide); // generating random number within the minimum and maximum range
            return diceOne;
        }
        // method to generate random number for dice two
        public static int RandomNumberGeneratorForDiceTwo( int numberOfSide)
        {
            int diceTwo;
            Random rand2 = new Random();
            diceTwo = rand2.Next(1, numberOfSide);
            return diceTwo; // return type
        }
    }
}

        




