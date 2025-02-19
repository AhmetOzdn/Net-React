using System.Text.RegularExpressions; // Regex kütüphanesini ekledik. şifredeki özel karakter ve büyük harf sorgusu için kullanacağız.

// 1: Sayının Pozitif, Negatif veya Sıfır Olduğunu Belirleme (if-else)

Console.Write("Bir sayı giriniz: ");
int input = Convert.ToInt32(Console.ReadLine());

if (input % 2 == 0)
{
    if (input != 0)
    {
        Console.WriteLine("Girdiğiniz sayi çift sayıdır.");
    }
    else
    {
        Console.WriteLine("Girdiğiniz sayı çift ve sıfır sayısıdır.");
    }
}
else if (input % 2 != 0)
{
    Console.WriteLine("Girdiğiniz sayi tek sayıdır.");
}
else
{
    Console.WriteLine("Lütfen bir sayı giriniz.");
}



// 2: Gün İsmi Belirleme (switch-case)
Console.Write("1-7 Arasında bir değer giriniz : ");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
        Console.Write(day +" => Pazartesi");
        break;
    case 2:
        Console.Write(day +" => Salı");
        break;
    case 3:
        Console.Write(day + " => Çarşamba");
        break;
    case 4:
        Console.Write(day + " => Perşembe");
        break;
    case 5:
        Console.Write(day + " => Cuma");
        break;
    case 6:
        Console.Write(day + " => Cumartesi");
        break;
    case 7:
        Console.Write(day + " => Pazar");
        break;
    default:
        Console.Write("Lütfen 1-7 arasında bir değer giriniz.");
        break;
}

// 3-Basit Hesap Makinesi(switch-case)
Console.Write("İşlem yapmak istediğiniz ilk sayıyı giriniz : ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("İşlem yapmak istediğiniz ikinci sayıyı giriniz : ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Yapmak istediğiniz işlemi seçiniz : \n1-Toplama\n2-Çıkarma\n3-Çarpma\n4-Bölme\n");
int operation = Convert.ToInt32(Console.ReadLine());

switch (operation)
{
    case 1:
        Console.WriteLine("Toplama işlemi sonucu : " + (number1 + number2));
        break;
    case 2:
        Console.WriteLine("Çıkarma işlemi sonucu : " + (number1 - number2));
        break;
    case 3:
        Console.WriteLine("Çarpma işlemi sonucu : " + (number1 * number2));
        break;
    case 4:
        Console.WriteLine("Bölme işlemi sonucu : " + (number1 / number2));
        break;
    default:
        Console.WriteLine("Lütfen 1-4 arasında bir değer giriniz.");
        break;
}

//4-Üç Sayının En Büyüğünü Bulma (if-else)

Console.Write("1. sayıyı giriniz : ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2. sayıyı giriniz : ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("3. sayıyı giriniz : ");
int number3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Yapmak istediğiniz işlemi seçiniz : \n1-Büyükten Küçüğe Sıralama\n2-Küçükten Büyüğe Sıralama\n3-En Büyük Sayıyı Bulma\n4-En Küçük Sayıyı Bulma\n");
int operation = Convert.ToInt32(Console.ReadLine());

if (operation == 1)
{
    int[] numbers = { number1, number2, number3 };
    Array.Sort(numbers);
    Array.Reverse(numbers);
    Console.WriteLine("Sayıların büyükten küçüğe sıralanmış hali aşağıdadır.");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i]);

        if (i < numbers.Length - 1)
        {
            Console.Write(" > ");
        }
    }
}
else if (operation == 2)
{
    int[] numbers = { number1, number2, number3 };
    Array.Sort(numbers);
    Console.WriteLine("Sayıların  küçükten büyüğe  sıralanmış hali aşağıdadır.");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i]);

        if (i < numbers.Length - 1)
        {
            Console.Write(" < ");
        }
    }
}
else if (operation == 3)
{
    Console.WriteLine("Girmiş olduğunuz sayılar arasından en büyüğü aşağıdadır.");
    int[] numbers = { number1, number2, number3 };
    int maxNumber = Int32.MinValue;
    for (int i = 0; i<numbers.Length; i++)
    {
        if (numbers[i] > maxNumber)
        {
            maxNumber = numbers[i];
        }
    }
    Console.WriteLine(maxNumber);
}
else if (operation == 4)
{
    Console.WriteLine("Girmiş olduğunuz sayılar arasından en küçüğü aşağıdadır.");
    int[] numbers = { number1, number2, number3 };
    int minNumber = Int32.MaxValue;
    for (int i = 0; i<numbers.Length; i++)
    {
        if (numbers[i] < minNumber)
        {
            minNumber = numbers[i];
        }
    }
    Console.WriteLine(minNumber);
}
else
{
    Console.WriteLine("Lütfen 1-4 arasında bir değer giriniz.");
}

//5-Şifre Güçlülüğünü Kontrol Etme (if-else)


Console.Write("Şifrenizi oluşturunuz : ");
string password = Console.ReadLine() ?? "";

if (password.Length < 8)
{
    Console.WriteLine("Şifre en az 8 karakter olmalıdır !");

    Console.Write("Şifrenizi tekrar oluşturunuz : ");
    password = Console.ReadLine() ?? "";
}
else if (!Regex.IsMatch(password, @"[@#$%]"))
{
    Console.WriteLine("Şifre en az bir adet @,#,$ veya % karakterlerinden birini içermelidir !");
    Console.Write("Şifrenizi tekrar oluşturunuz : ");
    password = Console.ReadLine() ?? "";
}
else if (!Regex.IsMatch(password, @"[A-Z]"))
{
    Console.WriteLine("Şifre en az bir adet büyük harf içermelidir !");
    Console.Write("Şifrenizi tekrar oluşturunuz : ");
    password = Console.ReadLine() ?? "";
}
else
{
    Console.WriteLine("Şifre başarılı bir şekilde oluşturuldu !");
    Console.WriteLine("Şifreniz : " + password);
}
