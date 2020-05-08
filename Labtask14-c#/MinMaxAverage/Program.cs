using System;

namespace MinMaxAverage
{
	class MainClass
	{
		public delegate void  MinMaxAverageDelegate ();

		public static void Main (string[] args)
		{

			MinMaxAverageDelegate maxMinAverageArrayValues = MaxMinAverageArrayValues;

			maxMinAverageArrayValues.Invoke ();
		}

		static public void MaxMinAverageArrayValues ()
		{
			int[] myArray = new int[]{ 266, 3, 4, 35, 6, 7, 8, 9 };
			int min = myArray [0];
			int max = 0;
			int sum = 0;
			//..............Minimum Number........................
			for (int i = 0; i < myArray.Length; i++) {
				if (myArray [i] < min) {

					min = myArray [i];
				}
			}
			Console.WriteLine ("The minimum number of the Array  is " + min);

			//.....................Maximum Number...........................

			for (int i = 0; i < myArray.Length; i++) {
				if (myArray [i] > max) {

					max = myArray [i];
				}
			}
			Console.WriteLine ("The Maximum number of the Array is " + max);

			//.....................Average Number ....................................
			for (int i = 0; i < myArray.Length; i++) {
				sum += myArray [i];
			}
			int average = sum / (myArray.Length);
			Console.WriteLine ("The Average number of the Array is " + average);

		}

	}
}
