using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MasterMind
{
	public class MasterMindMain
	{
        // Instantiate RandomAnswer and specify a 4 digit number with each number having a valid range of 1 to 6
        private static readonly int _answerSize = 4;
        private static readonly int _answerStartRange = 1;
        private static readonly int _answerEndRange = 6;
        
        
        private static RandomAnswer _randomAnswer = new RandomAnswer(_answerSize, _answerStartRange, _answerEndRange);
 
        private string _answer = _randomAnswer.Answer;
        
        public string Evaluate(string myAttempt)
		{
            Console.WriteLine("The answer is: " + _answer);

            // Ensure that a correct sized digit only value was entered
            if ((myAttempt.Length != _answerSize) || (!myAttempt.All(char.IsDigit)))
                return ("Invalid value entered.");

            var attemptString = new StringBuilder(myAttempt.Length);

            for (var myIndex = 0; myIndex < myAttempt.Length; myIndex++)
            {
                var number = myAttempt[myIndex];

                if (_answer.Contains(number))
                {
                    if (number == _answer[myIndex])
 
                        //Found a match for a number in the correct position
                        attemptString.Append('+');

                    else
                        //Found a match for a number but not in the correct position
                        attemptString.Append('-');
                }
                else
                    //Found no match for the number entered
                    attemptString.Append(' ');
            }
            return (attemptString.ToString());

        }




	}	   
}
