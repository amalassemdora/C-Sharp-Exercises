using System;
using System.Collections.Generic;
using System.Text;

namespace TryInheritance1
{
	class Circle:GeoShape
	{
		public Circle()
		{

		}
		public Circle(double _radius):base(_radius, _radius)
		{

		}
		public double CArea()
		{
			return Math.PI * dim1 * dim2;
		}
		public override double Area()
		{
			return Math.PI * dim1 * dim2;
		}
		public override double Area2()
		{
			return Math.PI * dim1 * dim2;
		}
	}
}
