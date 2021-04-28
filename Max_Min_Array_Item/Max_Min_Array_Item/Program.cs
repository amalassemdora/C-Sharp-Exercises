using System;

namespace Max_Min_Array_Item
{
	class Program
	{
		static void Main(string[] args)
		{
			//Ask user for the size of array
			Console.Write("Enter the size of array : ");
			int size = int.Parse(Console.ReadLine());
			int[] arr = new int[size];

			//Ask user for elements of array
			for (int i = 1; i <= arr.Length; i++) {
				Console.Write($"Enter number {i} : ");
				arr[i-1] = int.Parse(Console.ReadLine());
			}
			int max = arr[0];
			int min = arr[0];
			for (int i = 0; i < arr.Length; i++)
			{
				//Test the maximum number
				if (max < arr[i])
				{
					max = arr[i];
				}
				//Test the minimum number
				if (min > arr[i])
				{
					min = arr[i];
				}
			}
			//print Max and Min number
			Console.WriteLine($"The minimum number is {min}");
			Console.WriteLine($"The maximum number is {max}");
			Console.ReadKey();
		}
	}
}
