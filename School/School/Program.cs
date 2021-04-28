using System;

namespace School
{
	class Program
	{
		static void Main(string[] args)
		{
			//Ask the  user for the number of student
			Console.Write("Enter the number of student :");
			int std_num = int.Parse(Console.ReadLine());
			
			int std = 1;

			//Ask the user for student data and print it
			//Ask the user for student data (only one student)
			if (std_num == 1)
			{
				//make an object
				Student s = new Student();
				Console.WriteLine($"============================ Enter the data of student ============================");
				Console.Write("Enter Id: ");
				s.Id = int.Parse(Console.ReadLine());
				Console.Write("Enter Name : ");
				s.Name = Console.ReadLine();
				Console.Write("Enter Age : ");
				s.Age = int.Parse(Console.ReadLine());
				Console.Write("Enter Grade : ");
				s.Grade = double.Parse(Console.ReadLine());
				Console.Write("Enter Address : ");
				s.Address = Console.ReadLine();

				Console.WriteLine($"============================ Data of student ============================");
				//printr student data (only one student)
				s.Print();

			}
			else
			{
				//make array of objects
				Student[] std_arr = new Student[std_num];
				for (int i = 0; i < std_num; i++)
				{
					std_arr[i] = new Student();
					Console.WriteLine($"============================Enter the data of student number {std}============================");
					Console.Write("Enter Id: ");
					std_arr[i].Id = int.Parse(Console.ReadLine());
					Console.Write("Enter Name : ");
					std_arr[i].Name = Console.ReadLine();
					Console.Write("Enter Age : ");
					std_arr[i].Age = int.Parse(Console.ReadLine());
					Console.Write("Enter Grade : ");
					std_arr[i].Grade = double.Parse(Console.ReadLine());
					Console.Write("Enter Address : ");
					std_arr[i].Address = Console.ReadLine();

					std++;
				}
				Console.WriteLine($"============================ Data of students ============================\n");
				//printr student data (more than one student)
				for (int i = 0; i < std_num; i++)
				{
					Console.WriteLine(std_arr[i].Print2());
				}
			}
			Console.ReadKey();
		}
	}
}
