using System;

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal num1, num2,result=0;
			char operation;
			string replay = "yes";
			do { 
			Console.WriteLine("Enter num1");
			num1 = decimal.Parse(Console.ReadLine());
			Console.WriteLine("Enter num2");
			num2 = decimal.Parse(Console.ReadLine());
			Console.WriteLine("Enter operation");
			operation = char.Parse(Console.ReadLine());
			switch (operation)
			{
				case '+': 
					result = num1 + num2;
					break;
				case '-':
					result = num1 - num2;
					break;
				case '*':
					result = num1 * num2;
					break;
				case '/':
					result = num1 / num2;
					break;
				case '%':
					result = num1 % num2;
					break;
					default:
						Console.WriteLine("Enter the correct operation");
						break;
			}
			Console.WriteLine($"num1 {operation} num2 is {result}");
				Console.WriteLine("Do you want to perform another calculation? yes/no");
				replay = Console.ReadLine();
			} while (replay == "yes");
		}
	}
}
