using Private_Access_Specifier;

Console.WriteLine("Please Enter Your First Name");
string firstName = Console.ReadLine();
Person person1 = new Person();

person1.FirstName = firstName;
person1.middleName = "Faysal";
person1.lastName = "Ahmed";

string fullName = person1.GetFullName();
Console.WriteLine(fullName);