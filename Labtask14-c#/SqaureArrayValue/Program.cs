using System;

namespace SqaureArrayValue
{
	public delegate void  SquareArrayDelegate ();
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

			SquareArrayDelegate GetSqaureArrayValue = () => {
				int[] myArray = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9 };

				int square;


				for (int i = 1; i < myArray.Length; i++) {

					square = myArray [i] * myArray [i];
					Console.WriteLine (square);
					
				}
			};
			GetSqaureArrayValue ();

		}
	}
}
