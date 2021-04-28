using System;

namespace Company
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter the numer of employee : ");
			int num = int.Parse(Console.ReadLine());
			if (num == 1)
			{
				Employee e1 = new Employee();
				Console.WriteLine($"\n************ Enter Data Of Employee ************");
				Console.Write("Enter SSN : ");
				e1.Ssn = int.Parse(Console.ReadLine());
				Console.Write("Enter Name : ");
				e1.Name = Console.ReadLine();
				Console.Write("Enter Age : ");
				e1.Age = int.Parse(Console.ReadLine());
				Console.Write("Enter Salary : ");
				e1.Salary = decimal.Parse(Console.ReadLine());
				Console.Write("Enter Department : ");
				e1.Dept.DeptName = Console.ReadLine();
				Console.Write("Enter Day of hiring date : ");
				e1.Hdate.Day = int.Parse(Console.ReadLine());
				Console.Write("Enter Month of hiring date : ");
				e1.Hdate.Month = int.Parse(Console.ReadLine());
				Console.Write("Enter Tear of hiring date : ");
				e1.Hdate.Year = int.Parse(Console.ReadLine());
				Console.WriteLine($"\n************ Employee's data is ************\n");
				Console.WriteLine(e1.Print());
			}
			else if (num > 1)
			{
				Employee[] employees = new Employee[num];
				for (int i = 0; i < employees.Length; i++)
				{
					employees[i] = new Employee();
					Console.WriteLine($"\n***** Enter Data Of Employee # {i + 1}*****");
					Console.Write("Enter SSN : ");
					employees[i].Ssn = int.Parse(Console.ReadLine());
					Console.Write("Enter Name : ");
					employees[i].Name = Console.ReadLine();
					Console.Write("Enter Age : ");
					employees[i].Age = int.Parse(Console.ReadLine());
					Console.Write("Enter Salary : ");
					employees[i].Salary = decimal.Parse(Console.ReadLine());
					Console.Write("Enter Department : ");
					employees[i].Dept.DeptName = Console.ReadLine();
					Console.Write("Enter Day of hiring date : ");
					employees[i].Hdate.Day = int.Parse(Console.ReadLine());
					Console.Write("Enter Month of hiring date : ");
					employees[i].Hdate.Month = int.Parse(Console.ReadLine());
					Console.Write("Enter year of hiring date : ");
					employees[i].Hdate.Year = int.Parse(Console.ReadLine());
				}
				Console.Clear();
				Console.WriteLine($"\n************ Employees data************\n");
				for (int i = 0; i < employees.Length; i++)
				{
					Console.WriteLine(employees[i].Print());
				}
			}
			Console.ReadKey();

		}
	}
}
