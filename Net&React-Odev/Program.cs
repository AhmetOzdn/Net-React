
using Net_React_Odev;
using Net_React_Odev.Abstarct_Examples.Example_1;
using Net_React_Odev.Abstarct_Examples.Example_2;
using Net_React_Odev.Interface_Examples;
using Net_React_Odev.Interface_Examples.Example_1;
using Net_React_Odev.Interface_Examples.Example_2;

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


Console.WriteLine("------------------------------------------------------------------------------------");


// 3. Ödev Bölümü | Abstract class ve interface ile 2’şer örnek yapınız.

// Abstract Class Example 1
Circle circle = new Circle();
circle.Color = "Red";
circle.Draw();
circle.DisplayInfo();


Console.WriteLine("------------------------------------------------------------------------------------");


// Abstract Class Example 2
Banana banana = new Banana();
banana.MakeGetFruit();


Console.WriteLine("------------------------------------------------------------------------------------");

// Interface Example 1
IVehicle car = new Car();
car.Start();
car.Stop();
car.Accelerate();
car.Brake();


Console.WriteLine("------------------------------------------------------------------------------------");


//Interface Example 2

IPayment payment = new BitcoinPayment();
payment.ProcessPayment(1000);

