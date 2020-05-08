using System;

namespace ZeroOutNegativeValue
{
	public delegate void  NegativevaluesDelegate ();
	class MainClass
	{
		public static void Main (string[] args)
		{
			NegativevaluesDelegate SetTozero = () => {
				int[] myArray = new int[]{ 1, -2, 3, -4, 5, -6, 7, 8, 9 };
				for (int i = 1; i < myArray.Length; i++) {
					
					if (myArray [i] < 0) {

						myArray [i] = 0;
					}

					Console.Write (myArray [i] + " ");
				}
			};
			SetTozero ();

		}
	}
}
