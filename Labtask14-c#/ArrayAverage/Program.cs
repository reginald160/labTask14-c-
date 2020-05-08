using System;

namespace ArrayAverage
{
	public delegate void  ArrayAverageDelegate ();
	class MainClass
	{
		

		public static void Main (string[] args)
		{
			ArrayAverageDelegate GetAverage = () => {
				int[] myArray = new int[]{ 266, 3, 4, 35, 6, 7, 8, 9 };
				int sum = 0;


				for (int i = 0; i < myArray.Length; i++) {
					sum += myArray [i];
				}
				int average = sum / (myArray.Length);
				Console.WriteLine ("The Average number of the Array is " + average);

			};
			GetAverage ();
		}
	}
}
