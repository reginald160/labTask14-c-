using System;

namespace printOdds1To255
{
	public delegate void printOdds1ToDele ();
	class MainClass
	{
		public static void Main (string[] args)
		{      

			printOdds1ToDele printOdds = () => {
				int[] odd = { };
				for (int i = 0; i < 255; i++) {
					if (i % 2 != 0) {
						Console.WriteLine (i);
					}
				}

			};
			printOdds ();
		}
	}
}
