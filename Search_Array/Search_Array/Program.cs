using System;

namespace Search_Array
{
	class Program
	{
		static void Main(string[] args)
		{
			//Ask user to input size of array 
			Console.Write("Enter the size of array : ");
			int size = int.Parse(Console.ReadLine());
			int[] arr = new int[size];

			//Ask user to input array element
			for (int i = 1; i <= arr.Length; i++)
			{
				Console.Write($"Enter number {i} : ");
				arr[i - 1] = int.Parse(Console.ReadLine());
			}
			//Ask user to input the search element
			Console.Write("Enter the element you search for : ");
			int search = int.Parse(Console.ReadLine());
			//using flage to search
			bool flag = false;
			// search code 
			for (int i = 0; i < arr.Length; i++)
			{
				if (search == arr[i])
				{
					flag = true;
					break;
				}
			}
			Console.WriteLine();
			//Test Flag an print result of the search
			if (flag)
			{
				Console.WriteLine($" {search} is found in the array" );
			}
			else
			{
				Console.WriteLine($" {search} is not found in the array");
			}
			Console.ReadKey();
		}
	}
}
