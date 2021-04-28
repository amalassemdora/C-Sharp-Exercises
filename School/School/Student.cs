using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
	class Student
	{
		//Student fields
		int id;
		string name;
		int age;
		double grade;
		string address;
		//Id properity
		public int Id
		{
			set
			{
				id = value;
			}
			get
			{
				return id;
			}
		}
		//Name properity
		public string Name
		{
			set
			{
				name = value;
			}
			get
			{
				return name;
			}
		}
		//Age properity
		public int Age
		{
			set
			{
				age = value;
			}
			get
			{
				return age;
			}
		}
		// Grade properity
		public double Grade
		{
			set
			{
				grade = value;
			}
			get
			{
				return grade;
			}
		}
		//Address properity
		public string Address
		{
			set
			{
				address = value;
			}
			get
			{
				return address;
			}
		}

		//Print functions
		//Print function for only one student
		public void Print()
		{
			Console.WriteLine($" Id : {id}\t Name : {name}\t Age : {age}\t Grade : {grade}\t Address : {address} ");
		}
		//Print function for more than one student
		public string Print2()
		{
			return $" Id : {id}\t Name : {name}\t Age : {age}\t Grade : {grade}\t Address : {address} ";
		}
	}
}
