using System;

namespace NetBasicsDemo
{
	public class ToStringDemo
	{
		class Employee
		{
			public string FirstName { get; private set; }
			public string LastName { get; private set; }

			public Employee(string firstName, string lastName)
			{
				FirstName = firstName;
				LastName = lastName;
			}

			// подобная функциональность должна быть там где должна быть
			public override string ToString()
			{
				return string.Format("{0} {1}", FirstName, LastName);
			}
		}

		public static void Demo(string[] args)
		{
			var employee = new Employee("Martin", "Fowler");

			// почему будет вызван ToString() ?
			Console.WriteLine(employee);

		}
	}
}
