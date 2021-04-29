using System;
using System.Collections.Generic;
using System.Text;

namespace TryInheritance1
{
	class Square:GeoShape
	{
		public Square()
		{

		}
		public Square(double _dim):base(_dim,_dim)
		{

		}
		public double SArea()
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
