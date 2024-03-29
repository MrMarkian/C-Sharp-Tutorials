using System;

namespace Employees
{
	class Manager : Employee
	{	
		public int StockOptions { get; set; }

		public Manager(){}

		public Manager (string fullName, int age, int empID, float currPay, string ssn, int numbOfOpts) 
			: base (fullName,age,empID,currPay,ssn)
		{
			StockOptions = numbOfOpts;
			ID = empID;
			Age = age;
			Name = fullName;
			Pay = currPay;
			//SocialSecurityNumber = ssn;

		}

		public override void GiveBonus (float amount)
		{
			base.GiveBonus (amount);
			Random r = new Random ();
			StockOptions += r.Next (500);

		}

		public override void DisplayStats(){
			base.DisplayStats ();
			Console.WriteLine ("Number of  Stock Options: {0}", StockOptions);
		}

	}
}

