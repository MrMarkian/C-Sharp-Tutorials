using System;
using System.Collections;

namespace SimpleException
{
	class Radio
	{	public void TurnOn (bool on)
		{	if (on)
				Console.WriteLine ("Jamming... ");
			else 
				Console.WriteLine ("Quiet Time!");
		}
	}

	class Car
	{
		public const int MaxSpeed = 100;

		public int CurrentSpeed {get; set;} 
		public string PetName { get; set;}

		private bool carIsDead;

		private Radio theMusicBox = new Radio ();

		public Car(){}

		public Car (string name, int speed)
		{	CurrentSpeed = speed;
			PetName = name;
		}

		public void CrankTunes (bool state)
		{	theMusicBox.TurnOn (state);
		}

		public void Accelerate(int delta)
		{ if (carIsDead)
				Console.WriteLine ("{0} is out of order..", PetName);
			else
				CurrentSpeed += delta;
			if(CurrentSpeed > MaxSpeed)
			{
				Console.WriteLine ("{0} has overheated", PetName);
				CurrentSpeed = 0;
				carIsDead = true;
                Exception ex = new Exception(string.Format("{0} has overheated ", PetName));
                ex.HelpLink = "http://www.CarsRUs.com";
                ex.Data.Add("TimeStamp:", string.Format(" The car exploded at {0}", DateTime.Now));
                ex.Data.Add("Cause", "You have a lead foot..");
                throw ex;
			} else {
				Console.WriteLine ("=> Current Speed = {0}", CurrentSpeed);
			}
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{	Console.WriteLine ("Simple Exception Handling...");
			Console.WriteLine ("Creating a car and stepping on it.. ");
			Car myCar = new Car ("Zippy", 20);
			myCar.CrankTunes (true);
			try {
			for (int i = 0; i < 10; i++) {
				myCar.Accelerate (10);
				Console.ReadLine ();
			}

			}catch (Exception e){
				Console.WriteLine ("*** Error! ***");
				Console.WriteLine ("Method: {0}",e.TargetSite);
				Console.WriteLine ("Message: {0}", e.Message);
				Console.WriteLine ("Source: {0}",e.Source);
				Console.WriteLine ("Class Defining Member: {0}",e.TargetSite.DeclaringType);
				Console.WriteLine ("Member Type: {0}", e.TargetSite.MemberType);
				Console.WriteLine ("Stack Trace: {0}", e.StackTrace);
                Console.WriteLine("Help Link:{0}",e.HelpLink);
                Console.WriteLine("n-> Custom Data:");
                foreach (DictionaryEntry de  in e.Data)
                    Console.WriteLine("-> {0} : {1}",de.Key,de.Value);
            }
        }
	}
}
