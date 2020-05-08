using System;

namespace OddNumbers
{
	class MainClass
	{
		public delegate void ReturnOddDelegate ();

		public static void Main (string[] args)
		{

			ReturnOddDelegate ReturnOddsArray = () => {
				int[] odd = { };
				for (int i = 0; i < 255; i++) {
					if (i % 2 != 0) {
						Console.WriteLine (i);
					}
				}

			};
			ReturnOddsArray ();

		}
	}
}
