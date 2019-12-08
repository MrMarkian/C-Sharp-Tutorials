using System;

namespace Shapes
{
	abstract class Shape
	{
		public string PetName { get; set; }

		public Shape(string name = "NoName") {
			PetName = name;
		}

		public abstract void Draw ();
		
	}


	class Circle : Shape
	{
		public Circle() {}
		public Circle(string name) : base(name){}
		public override void Draw ()
		{
			Console.WriteLine ("Drawing {0} the Circle", PetName);
		}
	}

	class TheeDCircle : Circle
	{
		public string PetName { get; set;}

		public new void Draw(){
			Console.WriteLine ("Drawing a 3D Circle...");
		}
	}

	class Hexagon : Shape
	{
		public Hexagon (){}
		public Hexagon (string name) : base(name){}

		public override void Draw(){
			Console.WriteLine ("Drawing {0} the Hexagon",PetName);

		}
	}


	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Welcome to Fun with Shapes!!");
			Shape[] myShapes = {new Hexagon(), new Circle(), new Hexagon("Mick"), new Circle("Beth"), new Hexagon("Linda")};

			foreach (Shape s in myShapes)
			{	s.Draw ();
			}

		}
	}
}
