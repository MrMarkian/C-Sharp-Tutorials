using System;

namespace ObjectOverrides
{
	public class Person
	{

		public string FirstName { get; set;}
		public string LastName { get; set;}
		public int Age { get; set;}

		public Person ()
		{	}

		public Person(string fName, string lName, int personAge)
		{	FirstName = fName;
			LastName = lName;
			Age = personAge;
		}

		public override string ToString ()
		{	return string.Format ("[Person: FirstName={0}, LastName={1}, Age={2}]", FirstName, LastName, Age);
		}

		public override bool Equals(object obj)
		{
			if(obj is Person && obj !=null)
			{
				Person temp = (Person)obj;
				if (temp.FirstName == this.FirstName && temp.LastName == this.LastName && temp.Age == this.Age)
					return true;
				else
					return false;
			}
			return false;
		}

		public override int GetHashCode ()
		{
			return this.ToString ().GetHashCode ();

		}
	}
}

