using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
	class HireDate
	{
		#region fields
		int day;
		int month;
		int year;
		#endregion

		#region  props
		public int Day
		{
			set { day = value; }
			get { return day; }
		}
		public int Month
		{
			set { month = value; }
			get { return month; }
		}
		public int Year
		{
			set { year = value; }
			get { return year; }
		}
		#endregion

		#region ctors
		public HireDate()
		{
			day = 1;
			month = 1;
			year = 2001;
		}
		public HireDate(int d, int m, int y)
		{
			day = d;
			month = m;
			year = y;
		}
			#endregion

			#region print
			public string Print()
		{
			return $"{day}/{month}/{year}";
		}
		#endregion
	}
}
