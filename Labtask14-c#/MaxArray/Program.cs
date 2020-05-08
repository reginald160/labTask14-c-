using System;

namespace MaxArray
{
	class MainClass
	{
		public delegate void MaxArrayDelegate ();

		public static void Main (string[] args)
		{
			MaxArrayDelegate PrintMaxOfArray = () => {
				int[] myArray = new int[]{ 266, 3, 4, 35, 6, 7, 8, 9 };

				int max = myArray [0]; 

				for (int i = 0; i < myArray.Length; i++) {

					if (myArray [i] > max) {

						max = myArray [i];
					}
				}

				Console.WriteLine (max);
			};
			PrintMaxOfArray ();
		}
	}
}
