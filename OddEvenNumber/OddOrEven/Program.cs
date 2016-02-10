/*
 * C# Program to Check whether the Entered Number is Even or Odd
 */

using System;

namespace OddOrEven
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.Write("Enter a Number : ");
			var i = int.Parse(Console.ReadLine());
			if (i % 2 == 0)
			{
				Console.Write("Entered Number is an Even Number");
				Console.Read();
			}
			else
			{
				Console.Write("Entered Number is an Odd Number");
				Console.Read();
			}
		}
	}
}