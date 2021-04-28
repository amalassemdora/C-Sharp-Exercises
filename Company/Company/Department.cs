using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
	class Department
	{
		#region fields
		int deptId;
		String deptName;
		#endregion

		#region props
		public int DeptId
		{
			set { deptId = value; }
			get { return deptId; }
		}

		public string DeptName
		{
			set { deptName = value; }
			get { return deptName; }
		}
		#endregion

		#region ctors
		public Department()
		{
			deptId = 1;
			deptName = "IT";
		}
		public Department(int did, string dname)
		{
			deptId = did;
			deptName = dname;
		}
		#endregion

		#region Print
		public string Print()
		{
			return $"{deptName} Department";
		}
		#endregion
	}
}
