using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
	class Program
	{
		static void Main(string[] args)
		{
			//client 1
			DataStore<string> d = new DataStore<string>();
			d.Data = "arun";
			d.Display<string>("Client 1");

			//client 2
			DataStore<int> d1 = new DataStore<int>();
			d1.Data = 2;
			d1.Display<int>(2);

			Console.ReadKey();

			List<int> numbers = new List<int>();

			//List<DataStore<string>> l1 = new List<DataStore<string>>();
		}
	}

	class DataStore<T>
	{
		public T Data { get; set; }

		public void Display<T>(T clientName)
		{
			Console.WriteLine($"{clientName}: {Data}");
			Console.WriteLine("clientName: {0}", Data);
		}
	}
}
