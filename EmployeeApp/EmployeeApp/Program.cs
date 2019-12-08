using System;

namespace EmployeeApp
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Employee App .. ");
			Employee emp = new Employee ("Marvin",456,30000);
			emp.GiveBonus (1000);
			emp.Name = "Marv";
			emp.DisplayStats ();


			Employee emp2 = new Employee ();
			emp2.SetName ("Xena the warrior princess");

			Employee joe = new Employee ();
			joe.Age++;


		}
	}
}
