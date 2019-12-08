using System;
using Employees;

namespace Employees
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			SalesPerson fred = new SalesPerson ("Brenda",35,287,18000,"JN8276172A",247);
			fred.Age = 31;
			fred.Name = "Fred";
			fred.SalesNumber = 50;

			Manager chucky = new Manager ("Chucky", 50, 92, 10000, "333-23-2322", 9000);

			double cost = chucky.GetBenefitCost ();
			Console.WriteLine ("Benefits Cost:{0}", cost.ToString ());
			Employee.BenefitsPackage.BenefitPackageLevel myBenefitLevel = Employee.BenefitsPackage.BenefitPackageLevel.Platinum;

			chucky.GiveBonus (300);
			chucky.DisplayStats ();

			SalesPerson fran = new SalesPerson ("Fran", 43, 93, 30000, "832-32-3232", 31);

			fran.GiveBonus (200);
			fran.DisplayStats ();
			object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);
			Hexagon hex;
			try {hex = (Hexagon)frank;}
			catch (InvalidCastException ex)
			{Console.WriteLine (ex.Message);
			}

			object[] things = new object[4];
			things [0] = new Hexagon ();
			things [1] = false;
			things [2] = new Manager ();
			things[3] = "Last Thing";

			foreach (object item in things)
			{
				Hexagon h = item as Hexagon;
				if (h == null)
					Console.WriteLine ("Item is not a Hexagon");
				else
					h.Draw ();
			}

			CastingExamples ();
		}

		static void GivePromotion(Employee emp)
		{
			Console.WriteLine ("{0} was promoted!", emp.Name);

			if (emp is SalesPerson)
			{
				Console.WriteLine ("{0} made {1} sales..", emp.Name, ((SalesPerson)emp).SalesNumber);

			}

			if (emp is Manager)
				Console.WriteLine ("{0} had {1} Stock Options..", emp.Name, ((Manager)emp).StockOptions);
		}

		static void CastingExamples()
		{
			object frank = new Manager ("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);
			Employee moonUnit = new Manager ("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);
			SalesPerson jill = new PTSalesPerson ("Jill",834, 3002,100000,"111-12-1118",90);
			GivePromotion (moonUnit);
			GivePromotion (jill);
			GivePromotion ((Manager)frank);

		}

		class Hexagon
		{
			public void Draw() { Console.WriteLine ("Drawing a Hexagon!");}
		}
	}
}
