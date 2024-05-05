using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl3
{
	internal class Garage : IEnumerable
	{
		private List<Car> Cars;  
		public Garage()
		{
			Cars = new List<Car>();
		}

		public void AddCar(Car car)
		{
			Cars.Add(car);
		}

		public IEnumerator<Car> GetEnumerator()
		{
			return Cars.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

	}

	public class Car 
	{
		public string BrandName { get; }
		public string BoxType { get; }
		public string FuelType { get; }
		public string Color { get; }
		public Car(string nameB, string lasboxP, string fuelP, string colorP)
		{
			BrandName = nameB;
			BoxType = lasboxP;
			FuelType = fuelP;
			Color = colorP;
		}
	}
}
