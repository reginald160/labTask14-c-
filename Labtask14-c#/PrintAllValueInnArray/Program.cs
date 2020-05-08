using System;

namespace PrintAllValueInnArray
{
	public delegate void ReturnvaluesDelegate ();
	class MainClass
	{
		public static void Main (string[] args)
		{
			ReturnvaluesDelegate GetAllValues = () => {
				int[] myArray = new int[]{ 266, 3, 4, 35, 6, 7, 8, 9 };
				foreach (var number in myArray) {

					Console.WriteLine (number);
				}
			};                   
			GetAllValues ();

		}
	}
}
