using System;

namespace SelectionStatementEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int faveNum = 21;
            Console.WriteLine($"Guess my favorite Number between 1 and 30");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput == faveNum)
            {
                Console.WriteLine($"Great job you got it!!");



            }
            else if (userInput < faveNum)
            {
                Console.WriteLine($"A little to low my guy, bump it up some");



            }
            else if (userInput > faveNum)
            {
                Console.WriteLine($"Hey man Grandma said turn it down some..");



            }
            else;
            {

                Console.WriteLine($"");




            }






        }
    }  

}
