using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //making loop for fizz buzz
            for (int ii = 0; ii < 21; ii++)
            {
                FizzBuzz(ii);
            }
            //Letter counter parameters
            LetterCounter('i', "I love biscuits and gravy. It's the best breakfast ever.");
            LetterCounter('n', "Never going to give you up. Never going to let you down.");
            LetterCounter('s', "Sally sells seashells down by the seashore. She's from Sussex.");
            Console.ReadKey();
        }
        /// <summary>
        /// depending on if the number inserted is divisable by 3 or 5 FizzBuzz will write out Fizz, Buzz, FizzBuzz or the integer
        /// </summary>
        /// <param name="number">an integer</param>
        static void FizzBuzz(int number)
        {
            //checks to see if it is divisable by 3 and 5
            if (number % 3 == 0 && number % 5 == 0)
            {
                //number is divisable by 3 and 5 
                //writes out fizzbuzz
                Console.WriteLine("FizzBuzz");
            }
            //number is only divisable by 5
            else if (number % 5 ==0)
            {
                //number is divisable by 5
                //writes out fizz
                Console.WriteLine("Fizz");
            }
            //number is only divisable by 3
            else if (number % 3 == 0)
            {
                //number is divisable by 3
                //writes out buzz
                Console.WriteLine("Buzz");
            }
            //not divisable by 3 or 5 
            else
            {
                //returns the number
                Console.WriteLine(number);
            }         
        }
        /// <summary>
        /// Counts all letters by lowercase, uppercase, and total 
        /// </summary>
        /// <param name="letter"></param>
        /// <param name="inString"></param>
        public static void LetterCounter(char letter, string inString)
        {
            //create three counters for uppercase, lowercase, and total
            int counterLower = 0;
            int counterUpper = 0;
            int counterTotal = 0;
            //create lower and upper case variables for letter
            string letterLower = letter.ToString().ToLower();
            string letterUpper = letter.ToString().ToUpper();
           

            //create a for loop that loops through the entire inString
            for (int i = 0; i < inString.Length; i++)
            {
                //checks if current char is either lower or upper case letter
                if (inString[i] == letterLower[0] || inString[i] == letterUpper[0])
                {
                    //is either a lower or uppercase version of the letter
                    //adds to total counter
                    counterTotal++;
                    
                    //checks if char inString is equal to lower case letter
                    if (inString[i] == letterLower[0])
                    {
                        //is a lower case version of the letter
                        //add to lower Counter
                        counterLower++;
                    }
                    else
                    {
                        //it's a upper case version of letter 
                        counterUpper++;
                    }
                }
            }
            //writes out to console all the counters
            Console.WriteLine("Input: " + inString);
            Console.WriteLine("Number of lowercase {0}'s found: " + counterLower, letter);
            Console.WriteLine("Number of UPPERCASE {0}'s found: " + counterUpper, letterUpper);
            Console.WriteLine("Total Number of {0}'s found: " + counterTotal,letterUpper);
        }
    }
}
