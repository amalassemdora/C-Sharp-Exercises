using System;
using System.Collections.Generic;
using System.Text;

namespace TryInheritance1
{
	class Rectangle:GeoShape
	{
		public Rectangle()
		{

		}
		public Rectangle(double _dim1,double _dim2):base(_dim1,_dim2)
		{

		}
		public double RArea()
		{
			return dim1 * dim2;
		}
		public override double Area()
		{
			return dim1 * dim2;
		}
		public override double Area2()
		{
			return dim1 * dim2;
		}
	}
}
