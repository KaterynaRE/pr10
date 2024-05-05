using cl1;
using cl2;
using cl3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr10
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//Завдання 1
			//Створіть клас «Алфавіт», в якому мають міститися
			//літери англійського алфавіту.Реалізуйте підтримку ітератора.
			//Протестуйте можливість використання foreach для класу «Алфавіт»


			//Alphabet alphabet = new Alphabet();

			//foreach (char letter in alphabet)
			//{
			//	Console.Write($" {letter} ");
			//}
			//Console.WriteLine(); 

			//bool foundR = alphabet.Find('R');
			//Console.WriteLine($"Letter 'R' found: {foundR}");

			//Завдання 2
			//Створіть клас «Будинок», в якому має міститися інформація про квартири в цьому будинку.
			//Створіть клас «Квартира» з інформацією про мешканців квартир.Реалізуйте підтримку ітератора
			//для класів «Будинок» і «Квартира».
			//Протестуйте можливість використання foreach для класів «Будинок» і «Квартира»


			Person person1 = new Person("Ivan", "Ivanov", 35);
			Person person2 = new Person("Anna", "Ivanova", 30);
			Person person3 = new Person("Oleg", "Petrov", 40);
			Person person4 = new Person("Elena", "Petrova", 25);

			Appartment appartment1 = new Appartment();
			appartment1.AddResident(person1);
			appartment1.AddResident(person2);
			appartment1.CountRoom = 3;
			appartment1.NumberAppartment = 101;

			Appartment appartment2 = new Appartment();
			appartment2.AddResident(person3);
			appartment2.AddResident(person4);
			appartment2.CountRoom = 2;
			appartment2.NumberAppartment = 100;

			House house = new House();
			house.AddAppartment(appartment1);
			house.AddAppartment(appartment2);


			foreach (var appartment in house)
			{
				Console.WriteLine($"Appartment: number appartment: {appartment.NumberAppartment}, " +
					$"count room: {appartment.CountRoom}");			
				foreach (var person in appartment)
				{
					Console.WriteLine($"  Resident: {person.Name} {person.LastName}, Age: {person.Age}");
				}
			}

			//Завдання 3
			//Створіть клас «Гараж». Клас має містити інформацію про машини, які знаходяться в гаража.
			//Створіть клас «Автомобіль», в якому, відповідно, міститься інформація про автомобіль.
			//Реалізуйте підтримку ітератора для класу «Гараж».
			//Протестуйте можливість використання foreach для класу «Гараж».

			Car mercedes = new Car("Mercedes-Benz E class", "automat", "gasoline", "Black");
			Car audi = new Car("Audi SQ 8", "automat", "gasoline", "Black");

			Garage cars = new Garage();
			cars.AddCar(mercedes);
			cars.AddCar(audi);

			Console.WriteLine("\nCars in Garage:");
			foreach (var car in cars)
			{
				Console.WriteLine($"Car: name brand: {car.BrandName}, " +
					$"type box: {car.BoxType}, type fuel: {car.FuelType}, color car: {car.Color}");			
			}



		}


	}
	
}
