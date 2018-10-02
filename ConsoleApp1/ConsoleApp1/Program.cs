using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentification
{
	class Program
	{

		static void Main(string[] args)
		{

			Console.WriteLine("Select the day of a week: 1,2,3,4,5,6,7 ");
			string weekDay = Convert.ToString(Console.ReadLine());

			switch (weekDay)
			{
				case "1":
					weekDay = "Monday"; Console.ForegroundColor = ConsoleColor.Yellow;
					break;
				case "2":
					weekDay = "Tuesday"; Console.ForegroundColor = ConsoleColor.Gray;
					break;
				case "3":
					weekDay = "Wednesday"; Console.ForegroundColor = ConsoleColor.Blue;
					break;
				case "4":
					weekDay = "Thursday"; Console.ForegroundColor = ConsoleColor.Magenta;
					break;
				case "5":
					weekDay = "Friday"; Console.ForegroundColor = ConsoleColor.DarkRed;
					break;
				case "6":
					weekDay = "Saturday"; Console.ForegroundColor = ConsoleColor.DarkGreen;
					break;
				case "7":
					weekDay = "Sunday"; Console.ForegroundColor = ConsoleColor.DarkCyan;
					break;

				default:
					Console.WriteLine("Oops! You have entered wrong command, please try again! ");
					break;

			}

			Console.WriteLine(weekDay);



			Console.ReadKey();

		}
	}
}