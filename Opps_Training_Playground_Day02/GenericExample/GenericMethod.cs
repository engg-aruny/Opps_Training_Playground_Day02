using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Training_Playground_Day02.GenericExample
{
	public class GenericMethod
	{
		// Generics method 
		public void Display<TypeOfValue>(string msg, TypeOfValue value)
		{
			Console.WriteLine("{0}:{1}", msg, value);
		}
	}
}
