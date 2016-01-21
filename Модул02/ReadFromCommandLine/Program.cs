using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 5, b = 0;

			// Въвеждане на входни параметри
			Console.Write ("Моля въведете b: ");
			b = Convert.ToInt32 (Console.ReadLine ());

			//Печатане на резултата в конзолата
			Console.WriteLine ("Резултата от а + b е " + (a + b) + "\n" );
			string test = " 1";
			test += ", 2";
			test += ", 3";
			test += ", 4";
			test += ", 5";
			test += ", 6";

			Console.WriteLine ("Събиране с +=" + test + "\n");
			test = test.Replace (", ","; ");
			Console.WriteLine ("Работа с Replace :" + test + "\n");

			Console.WriteLine ("Третия знак е:" + test.Split (';') [2]);


	}
	}}
