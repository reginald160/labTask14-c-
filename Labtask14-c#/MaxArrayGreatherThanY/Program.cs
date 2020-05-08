using System;

namespace MaxArrayGreatherThanY
{
	class MainClass
	{
		public delegate void ReturnMaxDelegate ();

		public static void Main (string[] args)
		{
			ReturnMaxDelegate ReturnArrayCountGreatherThanMax = () => {
				int[] myArray = new int[]{ 266, 3, 4, 35, 6, 7, 8, 9 };

				int max = 7;


				for (int i = 0; i < myArray.Length; i++) {

					if (myArray [i] > max) {

						Console.WriteLine (myArray [i]);
					}
				}
			};
			ReturnArrayCountGreatherThanMax ();
		}
	}
}
