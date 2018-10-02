using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "My first App";
			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.DarkRed;
			Console.WriteLine("********************************************");
			Console.WriteLine("***************my First App*****************");
			Console.WriteLine("********************************************");
			Console.BackgroundColor = ConsoleColor.DarkGray;



			// Expercise

			Console.WriteLine("*********************************************");
				
			Console.Write("Enter your Last Name ");
			string lastname = Console.ReadLine();

			Console.Write("Enter your First name ");
			string firstname = Console.ReadLine();


			Console.Write("Enter your Birth Year ");
			short birthyear = Convert.ToInt16(Console.ReadLine());
			int year = 2018 - birthyear;

			Console.Write("Enter your Weight ");
			byte weigh = Convert.ToByte(Console.ReadLine());

			if (weigh < 99.9)
			{
				Console.WriteLine($"Dear  {lastname} {firstname} you are {year} year old and thin man");
			}
			else
			{
				Console.WriteLine($"Dear  {lastname} {firstname} you are {year} year old and fat man");


			}
			Console.ReadKey();

		}
	}
}
