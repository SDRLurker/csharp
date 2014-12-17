using System;

namespace csharp_84
{
	class Class1 : IEquatable<Class1>
	{
		public Int32 ID {get; set;}
		public String Name {get;set;}
		public bool Equals(Class1 other)
		{
			if (other == null)
				return false;
			if (this.ID != other.ID)
				return false;
			if (!Object.Equals (this.Name, other.Name))
				return false;
			//if (!this.Name.Equals (other.Name))	// <= this.Name이 null일 경우 Exception 발생!
			//	return false;
			return true;
		}
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			Class1 a = new Class1();
			Class1 b = new Class1 ();
			a.ID = 1;
			b.ID = 1;
			//a.Name = b.Name = "ab";
			//a.Name = "ab";
			//b.Name = "ab";
			Console.WriteLine ("a : " + a.Name);
			Console.WriteLine ("b : " + b.Name);

			Console.WriteLine (a.Equals (b));
		}
	}
}
