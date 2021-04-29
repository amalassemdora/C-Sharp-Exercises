using System;
using System.Collections.Generic;
using System.Text;

namespace TryInheritance1
{
	abstract class GeoShape
	{
		protected double dim1;
		protected double dim2;
			public GeoShape()
		{
			dim1 = dim2 = 0;
		}
		public GeoShape(double _dim1, double _dim2)
		{
			dim1 = _dim1;
			dim2 = _dim2;
		}
		public virtual double Area()
		{
			return -1;
		}
		public abstract double Area2();

	}
}
