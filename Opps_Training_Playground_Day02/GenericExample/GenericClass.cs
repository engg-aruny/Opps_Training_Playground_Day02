using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Training_Playground_Day02.GenericExample
{
	// C# program to show working of  
	// user defined Generic classes 
	using System;

	// We use < > to specify Parameter type 
	public class GFG<T>
	{
		// private data members 
		private T data;

		// using properties 
		public T value
		{

			// using accessors 
			get
			{
				return this.data;
			}
			set
			{
				this.data = value;
			}
		}
	}
}
