using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Training_Playground_Day02.AccessModifierExample
{
	class X
	{

		// Member x declared 
		// as protected 
		protected int x;

		public X()
		{
			x = 10;
		}
	}

	// class Y inherits the  
	// class X 
	class Y : X
	{

		// Members of Y can access 'x' 
		public int getX()
		{
			x = 20;
			return x;
		}
	}
}
