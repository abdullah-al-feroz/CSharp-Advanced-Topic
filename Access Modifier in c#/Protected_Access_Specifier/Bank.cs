using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected_Access_Specifier
{
	public class Bank
	{
		protected double _Amount;

		// Protected property to encapsulate _Amount
		protected double ProtectedAmount
		{
			set
			{
				if (value < 0)
				{
					throw new Exception("Please Pass a Positive Value");
				}
				else
				{
					_Amount = value;
				}
			}

			get
			{
				return _Amount;
			}
		}
	}
}
