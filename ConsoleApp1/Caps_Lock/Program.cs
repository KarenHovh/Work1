using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caps_Lock
{
	class Program
	{
		static void Main()
		{
			string value1 = "Lowercase string.";
			string upper1 = value1.ToUpper();
			Console.WriteLine(upper1);

			
			string value2 = "ABC123";
			string upper2 = value2.ToUpper();
			Console.WriteLine(upper2);


			Console.ReadKey();
		}
	}
}
