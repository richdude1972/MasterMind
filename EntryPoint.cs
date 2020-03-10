using System;

namespace MasterMind
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            // First, display the instructions screen.
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("*                                Welcome To MasterMind                                 *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("A unique 4 digit answer has been created.  Each digit of the answer can be a");
            Console.WriteLine("value from 1 to 6.");
            Console.WriteLine("");
            Console.WriteLine("Enter a 4 digit number and see if you have found the correct answer.");
            Console.WriteLine("");
            Console.WriteLine("After the answer is entered, a response will be returned indicating which,");
            Console.WriteLine("if any, of the numbers are correct:");
            Console.WriteLine("");
            Console.WriteLine("A \"+\" indicates that the digit was correct and the position in the answer was correct.");
            Console.WriteLine("A \"-\" indicates that the digit was correct but the position in the answer was wrong.");
            Console.WriteLine("A \" \" indicates that the digit is not in the answer.");
            Console.WriteLine("");
            Console.WriteLine("** A maximum of 10 attempts is allowed.  Press the \'Q\' key to quit. **");

            // Instantiate the Main MasterMind Object
            var masterMindMain = new MasterMindMain();
            var result = "";

            // Allow a maximum of 10 tries to get the answer
            int tries = 0;
            do
            {
                Console.Write("Attempt: ");
                var attempt = Console.ReadLine();

                //See if the player wants to quit
                if (attempt.ToUpper().Equals("Q"))
                {
                    break;
                }
                else
                {
                    result = masterMindMain.Evaluate(attempt);

                    //If one of the numbers entered is in the wrong spot, not part of the answer, or there is an error condition
                    if (result.Contains("-") || result.Contains(" "))
                    {
                        //Show the response    
                        Console.WriteLine(result);
                    }
                    else
                    {
                        //Player selected the correct answer
                        Console.WriteLine("Congratulations, you are correct!");
                        break;
                    }
                }
                tries++;



            } while (tries < 10);
   
            //Alert the player if the maximum turns have elapsed without finding the correct answer
            if (tries == 10)
                Console.WriteLine("Maximum attempts reached.  Thank you for playing.");
        }
    }
}
