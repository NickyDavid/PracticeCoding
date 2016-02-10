using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
	class Program
	{
		static void Main(string[] args)
		{
			var sum = 0;
			Console.WriteLine("Enter a Number : ");
			var num = int.Parse(Console.ReadLine());
			while (num != 0)
			{
				var r = num % 10;
				num = num / 10;
				sum = sum + r;
			}
			Console.WriteLine("Sum of Digits of the Number : " + sum);
			Console.ReadLine();

		}
	}
}
