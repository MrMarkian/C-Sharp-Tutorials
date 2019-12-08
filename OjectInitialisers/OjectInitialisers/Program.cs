using System;

namespace OjectInitialisers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Fun with Object Init Syntax...");

			Point firstPoint = new Point ();
			firstPoint.X = 10;
			firstPoint.Y = 10;
			firstPoint.DisplayStats ();

			Point anotherPoint = new Point (20, 20);
			anotherPoint.DisplayStats ();

			Point finalPoint = new Point() { X=30, Y=30 };
			finalPoint.DisplayStats ();

			Point pt = new Point (10, 16) { X=100, Y=100 };
			pt.DisplayStats ();

			Point goldPoint = new Point (PointColor.Gold) { X =90, Y=20 };
			goldPoint.DisplayStats ();

		}
	}
}
