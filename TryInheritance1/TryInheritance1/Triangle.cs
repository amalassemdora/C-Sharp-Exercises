using System;
using System.Collections.Generic;
using System.Text;

namespace TryInheritance1
{
	class Triangle:GeoShape
	{
		public Triangle()
		{

		}
		public Triangle(double _dim1,double _dim2):base(_dim1,_dim2)
		{

		}
		public double TArea()
		{
			return 0.5 * dim1 *dim2;
		}
		public override double Area()
		{
			return 0.5* dim1 * dim2;
		}
		public override double Area2()
		{
			return 0.5 * dim1 * dim2;
		}
	}
}
