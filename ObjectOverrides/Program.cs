using System;

namespace ObjectOverrides
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Fun with System.Object");

			Person p1 = new Person ();

			Console.WriteLine ("ToString: {0}", p1.ToString ());
			Console.WriteLine ("Hash Code: {0}", p1.GetHashCode ());
			Console.WriteLine ("Type: {0}", p1.GetType());

			Person p2 = p1;
			object o1 = p2;

			if(o1.Equals (p1) && p2.Equals (o1))
				Console.WriteLine ("Same Instance");

		}
	}
}
