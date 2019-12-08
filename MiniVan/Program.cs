using System;

namespace MiniVan
{
	class Car 
	{
		public readonly int maxSpeed;
		private int currSpeed;

		public Car(int max) {
			maxSpeed = max;
		}

		public Car() {
			maxSpeed = 55;
		}

		public int Speed {
			get { return currSpeed;}
			set {
				currSpeed = value;
				if (currSpeed > maxSpeed)
					currSpeed = maxSpeed;
			}
		}
	}

	class Program
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Basic Inheritance!");
			MiniVan myVan = new MiniVan ();
			myVan.Speed = 10;

				Console.WriteLine ("My van is going {0} MPH", myVan.Speed);

		}
	}
}
