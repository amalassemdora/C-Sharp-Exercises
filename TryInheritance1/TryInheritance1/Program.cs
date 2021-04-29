using System;

namespace TryInheritance1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("\n\tShape\t\tOwn class \tVirtual class\t\tAbstract class");
			Square s1 = new Square(10);
			Console.Write("\n\tSquare\t\t");
			Console.Write($"{s1.SArea()}\t\t\t");
			Console.Write($"{s1.Area()}\t\t\t");
			Console.Write($"{s1.Area2()}\n");

			Console.Write("\n\tSquare2\t\t");
			Square2 s2 = new Square2(20);
			Console.Write($"{s2.RArea()}\t\t\t");
			Console.Write($"{s2.Area()}\t\t\t");
			Console.Write($"{s2.Area2()}\n");

			Console.Write("\n\tRectangle\t");
			Rectangle r1 = new Rectangle(5, 4);
			Console.Write($"{r1.RArea()}\t\t\t");
			Console.Write($"{r1.Area()}\t\t\t");
			Console.Write($"{r1.Area2()}\n");


			Console.Write("\n\tCircle\t\t");
			Circle c1 = new Circle(8);
			Console.Write($"{c1.CArea()}\t");
			Console.Write($"{c1.Area()}\t");
			Console.Write($"{c1.Area2()}\n");

			Console.Write("\n\tTriangle\t");
			Triangle t1 = new Triangle(6, 7);
			Console.Write($"{t1.TArea()}\t\t\t");
			Console.Write($"{t1.Area()}\t\t\t");
			Console.Write($"{t1.Area2()}\n");

			Console.ReadKey();
		}
	}
}
