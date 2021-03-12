using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Training_Playground_Day02.PropertiesExample
{
	public class Person
	{
		private string name; // field

		public string Name   // property
		{
			get { return name; }   // get method
			set { name = value; }  // set method
		}
	}
}
