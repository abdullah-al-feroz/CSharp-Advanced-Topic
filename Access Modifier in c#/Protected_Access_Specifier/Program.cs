using Protected_Access_Specifier;

AnotherBank anotherBank = new AnotherBank();
anotherBank.UpdateAmount(20);
Console.WriteLine(anotherBank.GetAmount()); // Output: 20
