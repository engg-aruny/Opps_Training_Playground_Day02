using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Training_Playground_Day02.PropertiesExample
{
	public class Person
	{
		private string firstName; // field

		public string FirstName   // property
		{
			set { firstName = value; }  // set method
			get { return firstName; }   // get method
		}

		private string lastName; // field

		public string LastName   // property
		{
			set { lastName = value; }  // set method
			get { return lastName; }   // get method
		}


		private string name; // field

		public string Name   // property
		{
			//set { name = value; }  // set method
			get { return firstName + " " + lastName; }   // get method
		}
	}
}
