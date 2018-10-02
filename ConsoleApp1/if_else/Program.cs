using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Select the day of a week: 1,2,3,4,5,6,7 ");
			byte weekDay = Convert.ToByte(Console.ReadLine());


			if (weekDay == 1)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("Monday");
			}
			else if (weekDay == 2)
			{
				Console.ForegroundColor = ConsoleColor.DarkBlue;
				Console.WriteLine("Tuesday");
			}
			else if (weekDay == 3)
			{
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.WriteLine("Wednesday");
			}
			else if (weekDay == 4)
			{
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.WriteLine("Thursday");
			}
			else if (weekDay == 5)
			{
				Console.ForegroundColor = ConsoleColor.Magenta;
				Console.WriteLine("friday");
			}
			else if (weekDay == 6)
			{
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.WriteLine("saturday");
			}
			else if (weekDay == 7)
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Sunday");
			}
			else
			{
				Console.WriteLine("Oops! You have entered wrong command, please try again! ");
			}

			Console.ReadKey();
		}
	}
}
