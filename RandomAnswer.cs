using System;
using System.Text;

namespace MasterMind
{
	public class RandomAnswer
	{
		//get and set for the answer string
		public string Answer
		{ get; set; }

		private static Random _randomNumber = new Random();

		public RandomAnswer(int size, int start, int end)
		{
			//Build a string of the specified size
			var answerString = new StringBuilder(size);

			for (int index = 0; index < size; index++)
			{
				answerString.Append(_randomNumber.Next(start, end));
			}
			Answer = answerString.ToString();
		}
	}
}