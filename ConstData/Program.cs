using System;

namespace ConstData
{

	class MyMathClass 
	{	public static readonly double PI; 
		static MyMathClass() {PI=3.14;}
	}

	class Program
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Fun with const....");
			Console.WriteLine ("The value of Pi is:{0}",MyMathClass.PI);
		}

		static void LocalConstStringVariable(){
			const string fixedStr = "Fixed string data";

		}
	
	
	}



}
