using System;

namespace Sort_Array
{
	class Program
	{
		static void Main(string[] args)
		{
			int temp = 0;
			int index = 0;
			//Ask user to input size of array  
			Console.Write("Enter the size of array: ");
			int size = int.Parse(Console.ReadLine());
			int[] arr = new int[size];

			//Ask user to input array element
			for (int i = 1; i <= arr.Length; i++)
			{
				Console.Write($"Enter number {i} : ");
				arr[i - 1] = int.Parse(Console.ReadLine());
			}
			
			//Make Ascending sort
			for (int i = 0; i < arr.Length; i++)
			{
				temp = arr[i];
				for (int j = i; j < arr.Length; j++)
				{
					if (temp > arr[j])
					{
						temp = arr[j];
						index = j;
					}
				}			
				arr[index] = arr[i];
				arr[i] = temp;
			}
			//print sorted array
			Console.WriteLine();
			Console.Write("Ascending sort : ");
			for (int i = 0; i <arr.Length; i++)
			{
				Console.Write($"\t{arr[i]}" );
			}
			Console.WriteLine();
			Console.Write("Descending sort : ");
			for (int i = arr.Length-1; i >= 0; i--)
			{
				Console.Write($"\t{arr[i]}");
			}

			Console.ReadKey();
		}
	}
}
