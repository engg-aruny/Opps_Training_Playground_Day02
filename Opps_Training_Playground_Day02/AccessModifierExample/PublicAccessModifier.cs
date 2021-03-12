using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Training_Playground_Day02.AccessModifierExample
{
	class Student
	{

		// Declaring members rollNo 
		// and name as public 
		public int rollNo;
		public string name;

		// Constructor 
		public Student(int r, string n)
		{
			rollNo = r;
			name = n;
		}

		// methods getRollNo and getName 
		// also declared as public 
		public int getRollNo()
		{
			return rollNo;
		}

		public string getName()
		{
			return name;
		}
	}
}
