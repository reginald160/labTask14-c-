using System;

namespace PrintIntAndSumInt
{
	class MainClass
	{
		public delegate void ReturnIntegerSumdelegate ();

		public static void Main (string[] args)
		{
			ReturnIntegerSumdelegate PrintIntsAndSum = () => {

				int temp = 0;

				for (int i = 0; i < 255; i++) {

					Console.WriteLine (i);
					temp += i;
				}
				Console.Write ("The Sum of intergers is of 0 to 255 is " + temp);

			};
			PrintIntsAndSum ();
		}
	}
}
