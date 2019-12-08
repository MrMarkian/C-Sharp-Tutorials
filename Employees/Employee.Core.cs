using System;
namespace Employees
{
	abstract partial class Employee
	{	protected string empName;
		protected int empID;
		protected float currPay;
		protected int empAge;
		protected string empSSN;
		protected BenefitsPackage empBenefits = new BenefitsPackage();

		public double GetBenefitCost() {
			return empBenefits.ComputePayDeduction ();
		}

		public BenefitsPackage Benefits
		{
			get { return empBenefits;}
			set { empBenefits = value;}

		}

		public string Name {
			get { return empName;}
			set {	if (value.Length > 15)
						Console.WriteLine ("Error! Name exceeds 15 length");
					else
						empName = value;
			}
		}

		public int Age {
			get { return empAge;}
			set { empAge = value;}
		}

		public int ID {
			get { return empID;}
			set { empID = value;}
		}

		public float Pay {
			get{ return currPay;}
			set { currPay = value;}
		}

		public string SocialSecurityNumber
		{ get { return empSSN; } }

		// constructors----
		public Employee (){	}

		public Employee(string name, int age, int id, float pay, string ssn) :this (name, age,id,pay){
			empSSN = ssn;
		}

		public Employee(string name, int age,int id, float pay)
		{	Name = name;
			Age = age;
			ID = id;
			Pay = pay;
		}

		// Members -----
		public string GetName() {
			return Name;
		}

		public void SetName(string name){
			if (name.Length > 15)
				Console.WriteLine ("Error! Name exceeds 15 characters!");
			else
				Name = name;
		}


		public virtual void GiveBonus(float amount){
			Pay += amount;
		}

		public virtual void DisplayStats(){
			Console.WriteLine ("Name: {0}", empName);
			Console.WriteLine ("ID: {0}", empID);
			Console.WriteLine ("Age: {0}", empAge);
			Console.WriteLine ("Pay: {0}", currPay);
			Console.WriteLine ("SSN: {0}", SocialSecurityNumber);
	}

		public class BenefitsPackage
		{
			public double ComputePayDeduction() {return 125.0;}
			public enum BenefitPackageLevel {Standard,Gold,Platinum}
			public BenefitsPackage ()
			{
			}
		}
}
}
