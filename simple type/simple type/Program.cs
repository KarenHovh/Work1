using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_type
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("------int-------");

			int z_int = 4;
			int w_int = 8;

			int Add_int = z_int + w_int;
			int Sub_int = z_int - w_int;

			int Mul_int = z_int * w_int;

			Console.WriteLine($"{z_int} + {w_int} = {Add_int}");
			Console.WriteLine($"{z_int} - {w_int} = {Sub_int}");
			Console.WriteLine($"{z_int} * {w_int} = {Mul_int}");



			if (w_int == 0)
			{
				int Div_int = z_int / w_int;
				Console.WriteLine($"{z_int} / {w_int} = {Div_int}");
			}
			else
			{
				Console.WriteLine("Can't divide by 0");

			}

			Console.WriteLine("------bool-------");

			bool flag = true;
			flag = true;

			if (true)
				Console.WriteLine("true");


			Console.WriteLine("-----byte-----");
			byte a_byte = 8;
			byte b_byte = 9;
			byte Add_byte = (byte)(a_byte + b_byte);
			byte Div_byte = (byte)(a_byte / b_byte);
			byte Mul_byte = (byte)(a_byte * b_byte);
			byte Sub_byte = (byte)(a_byte - b_byte);

			Console.WriteLine($"{a_byte} + {b_byte} = {Add_byte}");
			Console.WriteLine($"{a_byte} - {b_byte} = {Sub_byte}");
			Console.WriteLine($"{a_byte} * {b_byte} = {Mul_byte}");


			if (b_byte != 0) ;
			{

				Console.WriteLine($"{a_byte} / {b_byte} = {Div_byte}");
			}
			
			else
			{
				Console.WriteLine("Can't divide by 0");
			}

			Console.WriteLine("-----string-----");

			//string
			string a = "Hello ";
			string b = "world";
			Console.WriteLine(a + b);
			Console.WriteLine(a + b == "Hello World");


			Console.WriteLine("-----long----");

			long longValue1 = 124578;
			Console.WriteLine(longValue1);

			long longValue2 = 0x12547848;
			Console.WriteLine(longValue2);

			long longValue3 = (longValue1*longValue2);
			Console.WriteLine(longValue3);

			Console.ReadKey();
		}
	}
}
