using HomeWork3_8_3;

var john = new Post();
john.FirstName = "John";
john.LastName = "Doe";
john.Position = EPosition.RegularWorker;

Console.WriteLine($"Is Bonus applied for {john.FirstName} {john.LastName}: {Accountant.AskForBonus(john, 101)}");
