using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
	class Employee
	{
		#region fields
		int ssn;
		string name;
		int age;
		decimal salary;
		Department dept;
		HireDate hdate;
		#endregion

		#region props
		public int Ssn
		{
			set { ssn = value; }
			get { return ssn; }
		}
		public string Name
		{
			set { name= value; }
			get { return name; }
		}
		public int Age
		{
			set { age = value; }
			get { return age; }
		}
		public decimal Salary
		{
			set { salary = value; }
			get { return salary; }
		}
		public Department Dept
		{
			set { dept = value; }
			get { return dept; }
		}
		public HireDate Hdate
		{
			set { hdate = value; }
			get { return hdate; }
		}
		#endregion
		#region ctors 
		public Employee()
		{
			ssn = 1;
			name = "Amal";
			age = 25;
			salary = 10000;
			dept = new Department(10, "CS");
			hdate = new HireDate(10, 10, 2010);
		}
		public Employee(int _ssn,string _name,int _age,decimal _salary,Department _dept, HireDate _hdate)
		{
			ssn = _ssn;
			name = _name;
			age = _age;
			salary = _salary;
			dept = _dept;
			hdate = _hdate;
		}
		#endregion

		#region print
		public string Print()
		{
			return $"SSn : {ssn}\t Name : {name}\t Age : {age}\t Salary : {salary}\t Department : {dept.Print()}\t Hire Date : {hdate.Print()}";
		}
		#endregion
	}
}
