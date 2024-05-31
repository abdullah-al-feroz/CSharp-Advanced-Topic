using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected_Access_Specifier
{
	public class AnotherBank:Bank 
	{
		public void UpdateAmount(double newAmount)
		{
			// Can access and modify _Amount via ProtectedAmount property
			ProtectedAmount = newAmount;
		}

		public double GetAmount()
		{
			// Can access _Amount via ProtectedAmount property
			return ProtectedAmount;
		}
	}
}
