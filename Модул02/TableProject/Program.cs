using System;

namespace TableProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string [] row = new string [3]; 
			row [0] = "ред 1";
			row [1] = "ред 2";
			row [2] = "ред 3";
			Console.WriteLine ("Масив row: "+row [0]+", "+row [1]+", "+row [2]+"\n");

			string[] parse = "1;2;3;4;5;6;7;8;9".Split(';');
			Console.WriteLine ("Броят на цифрите в този масив \n"+"1,2,3,4,5,6,7,8,9\ne:"+parse.Length);

			//Печатане на третата цифра от масива parse

			Console.WriteLine ("Третата цифра в този масив\n1;2;3;4;5;6;7;8;9\nе:"+parse[2]+"\n");

			string list1 = string.Join ("*", parse) ;
			Console.WriteLine ("Новият стринг e:\n"+list1);







		}
	}
}
