using System;
using System.Collections;
using System.Collections.Generic;

namespace csharp_101
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			ArrayList array1 = new ArrayList ();
			int var1 = 10;
			int var2;
			array1.Add (var1);
			//var2 = ((List<int>)array1) [0];

			//var2 = array1 [0];
			//var2 = ((int[])array1)[0];
			var2 = Convert.ToInt32 (array1 [0]);
			Console.WriteLine (var2);
		}
	}
}
