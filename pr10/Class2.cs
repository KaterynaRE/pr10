using cl1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace cl2
{
	public class House : IEnumerable
	{
		private List<Appartment> appartments;  // Список квартир в будинку
		public House()
		{
			appartments = new List<Appartment>();
		}

		public void AddAppartment(Appartment appartment)
		{
			appartments.Add(appartment);
		}

		public IEnumerator<Appartment> GetEnumerator()
		{
			return appartments.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	public class Appartment : IEnumerable<Person>
	{
		private List<Person> residents;  // Список мешканців квартири
		public int CountRoom { get; set; }
		public int NumberAppartment { get; set; }
		public Appartment()
		{
			residents = new List<Person>();
		}

		public void AddResident(Person person)
		{
			residents.Add(person);
		}

		public IEnumerator<Person> GetEnumerator()
		{
			return residents.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}


	public class Person
	{
		public string Name { get; }
		public string LastName { get; }
		public int Age { get; }
		public Person(string name, string lastName, int age)
		{
			Name = name;
			LastName = lastName;
			Age = age;

		}
	}


}
