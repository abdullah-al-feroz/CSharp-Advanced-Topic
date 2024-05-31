using System;

namespace Private_Access_Specifier
{
	public class Person
	{
		private string firstName;

		public string FirstName
		{
			set
			{
				if (value.Length >= 2)
				{
					firstName = value;
				}
			}
			get
			{
				return firstName;
			}
		}

		public string middleName;
		public string lastName;

		//public void SetFirstName(string firstName)
		//{
		//	this.firstName = firstName;
		//}

		//public string GetFirstName()
		//{
		//	return firstName;
		//}

		public string GetFullName()
		{
			string fullName = firstName + "" + middleName + "" + lastName;
			return fullName;
		}
	}
}
