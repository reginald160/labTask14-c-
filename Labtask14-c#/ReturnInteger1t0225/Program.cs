using System;

namespace ReturnInteger1t0225
{
	class MainClass
	{
		public delegate void ReturnIntegers ();

		public static void Main (string[] args)
		{
			ReturnIntegers returnInteger = () => {
				for (int i = 1; i <= 225; i++) {
					Console.WriteLine (i);
				}
				;
			};                   
			returnInteger ();
		}
	}
}
