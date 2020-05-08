using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace ShiftArrayValueToLeft
{
	public delegate void ShiftArrayDelegate ();
	class MainClass
	{
		public static void Main (string[] args)
		{
			ShiftArrayDelegate PrintMaxOfArray = () => {
				int[] myArray = new int[]{ 0, 266, 3, 4, 0, 35, 6, 7, 8, 9 };
				int[] newindex = new int[myArray.Length];


				//int  = myArray [0]; 

				for (int i = 0; i < myArray.Length - 1; i++) {

					newindex [i - 1] = myArray [i];
					newindex [0] = myArray [myArray.Length - 1];
					Console.WriteLine (newindex);
				}



			};
			PrintMaxOfArray ();


		}
	}
}
