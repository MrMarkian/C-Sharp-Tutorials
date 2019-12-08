using System;
namespace EmployeeApp
{
	partial class Employee
	{
	
	private string empName;
		private int empID;
		private float currPay;
		private int empAge;
		private string empSSN;

		public string Name {
			get { return empName;}
			set {
				if (value.Length > 15)
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

		public Employee(string name, int id, float pay) :this (name, 0,id,pay){
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


		public void GiveBonus(float amount){
			Pay += amount;
		}

		public void DisplayStats(){
			Console.WriteLine ("Name: {0}", empName);
			Console.WriteLine ("ID: {0}", empID);
			Console.WriteLine ("Age: {0}", empAge);
			Console.WriteLine ("Pay: {0}", empPay);
	
	}
}

