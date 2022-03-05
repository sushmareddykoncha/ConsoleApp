using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Generics
    {
		public class Program
		{
			public static void Main()
			{
				DataStore<string> cities = new DataStore<string>();
				cities.AddOrUpdate(0, "Mumbai");
				cities.AddOrUpdate(1, "Chicago");
				cities.AddOrUpdate(2, "London");

				Console.WriteLine(cities.GetData(0));

				DataStore<int> empIds = new DataStore<int>();
				empIds.AddOrUpdate(0, 50);
				empIds.AddOrUpdate(1, 65);
				empIds.AddOrUpdate(2, 89);

				Console.WriteLine(empIds.GetData(1));

			}
		}

		class DataStore<T>
		{
			private T[] _data = new T[10];

			public void AddOrUpdate(int index, T item)
			{
				if (index >= 0 && index < 10)
					_data[index] = item;
			}

			public T GetData(int index)
			{
				if (index >= 0 && index < 10)
					return _data[index];
				else
					return default(T);
			}
		}



		
			}
		}

		class DataStore<T>
		{
			private T[] _data = new T[10];

			public void AddOrUpdate(int index, T item)
			{
				if (index >= 0 && index < 10)
					_data[index] = item;
			}

			public T GetData(int index)
			{
				if (index >= 0 && index < 10)
					return _data[index];
				else
					return default(T);
			}
		}


	


        
