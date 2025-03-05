
using Net_React_Odev;

// 1. Ödev Bölümü
Manager manager = new Manager();
Developer developer = new Developer();

manager.Salary = 2000;
Console.WriteLine($"Manager salary with executive bonus added: {manager.CalculateBonus()}");

developer.Salary = 3000;
Console.WriteLine($"Developer salary with executive bonus added: {developer.CalculateBonus()}");



Console.WriteLine("------------------------------------------------------------------------------------");


// 2. Ödev Bölümü
BankAccount<string> checkingAccount = new CheckingAccount();
BankAccount<float> savingsAccount = new SavingsAccount();

savingsAccount.Balance = 1000;
Console.WriteLine($"Savings Account Calculated Balance : {savingsAccount.CalculateInterest()}");

checkingAccount.Balance = 1000;
Console.WriteLine($"Checking Account Calculated Balance : {checkingAccount.CalculateInterest()}");