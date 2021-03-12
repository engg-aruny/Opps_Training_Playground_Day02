using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Training_Playground_Day02.ClassMembersExample
{
	class Developer
	{
		private int salary;
		public Developer(int s)
		{
			this.salary = s;
		}

		public int GetSalary()
		{
			return this.salary;
		}
	}
}
