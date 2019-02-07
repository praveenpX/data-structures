using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Find all supervisors for an employee");
		Employee e1 = new Employee(1, "super1");
		Employee e2 = new Employee(2, "e2");
		e2.SuperVisor = e1;
		Employee e3 = new Employee(3, "e3");
		e3.SuperVisor = e2;
		FindAllSupervisors(e3);
	}

	public static void FindAllSupervisors(Employee employee)
	{
		if (employee == null)
			return;
		if (employee.SuperVisor == null)
			return;
		Console.WriteLine(employee.SuperVisor.Name);
		FindAllSupervisors(employee.SuperVisor);
	}

	public class Employee
	{
		public int Id
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

		public Employee SuperVisor
		{
			get;
			set;
		}

		public Employee(int id, string name)
		{
			Id = id;
			Name = name;
		}
	}
}
