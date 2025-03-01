
// 1-For döngüsü ile sayının rakamlarının toplamını bulan algoritma 
    Console.Write("Bir sayı girin: ");
    int inputNumber = Convert.ToInt32(Console.ReadLine());

    int sum = 0;

    for (; inputNumber > 0; inputNumber /= 10)
    {
        sum += inputNumber % 10;
    }

    Console.WriteLine("Girdiğiniz Sayının Rakamları Toplamı: " + sum);

// 2-While döngüsü ile kullanıcıdan belirli şartlara uyan bir değer alan algoritma

Console.Write("Bir sayı girin: ");
    int selectedNumber = Convert.ToInt32(Console.ReadLine());

    while (selectedNumber > 0)
    {
        if (selectedNumber >= 10 && selectedNumber <= 100)
        {
            Console.WriteLine("Girilen sayı 0-100 arasındadır.");
            break;
        }
        Console.Write("Lütfen 10 ila 100 arasında bir sayı girin: ");
        selectedNumber = Convert.ToInt32(Console.ReadLine());
    }


// 3-foreach döngüsü ile kişilerin yaş kategorisini belirleyen algoritmayı yazınız.

List<int> peopleAges = new List<int> { 15, 25, 45, 65, 33, 25, 57, 42, 79, 11, 8, 3, 24, 28 };

    foreach (var age in peopleAges)
    {
        if (age > 0 && age <= 12)
        {
            Console.WriteLine("Çocuk");
        }
        else if (age > 12 && age <= 19)
        {
            Console.WriteLine("Genç");
        }
        else if (age >= 20 && age <= 64)
        {
            Console.WriteLine("Yetişkin");
        }
        else
        {
            Console.WriteLine("Yaşlı");
        }
    }

// 4-Bir dizide tekrar eden elemanları bulan algoritmayı yazınız.

int[] numbers = { 1, 1, 1, 2, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    List<int> duplicateNumbers = new List<int>();

    for (int i = 0; i < numbers.Length; i++)
    {
        for (int j = i + 1; j < numbers.Length; j++)
        {
            if (numbers[i] == numbers[j] && !duplicateNumbers.Contains(numbers[i]))
            {
                duplicateNumbers.Add(numbers[i]);
            }
        }
    }
    Console.Write("Tekrar Eden Sayılar : ");
    foreach (var number in duplicateNumbers)
    {
        Console.Write(number + " ,");
    }

// 5-Bir dizide en uzun ve en kısa kelimeyi bulan algoritmayı yazınız.

string[] words = { "elma", "armut", "kiraz", "karpuz", "muz", "kavun", "kestane" };

    string longestWord;

    for (int i = 1; i < words.Length; i++)
    {
        for (int j = 0; j < words.Length - i; j++)
        {
            if (words[j].Length > words[j + 1].Length)
            {
                string temp = words[j];
                words[j] = words[j + 1];
                words[j + 1] = temp;
            }
        }
    }

    Console.WriteLine("En Kısa Kelime : " + words[0]);
    Console.WriteLine("En Uzun Kelime : " + words[words.Length - 1]);


// 6-Kullanıcının girdiği bir cümleyi diziye kaydeden ve alfabetik olarak sıralayan algoritmayı yazınız.
Console.Write("Bir cümle giriniz : ");
    string sentence = Console.ReadLine();

    string[] words = sentence.Split(' ');

    Array.Sort(words);

    Console.WriteLine("Alfabetik Sıralama : ");
    foreach (var word in words)
    {
        Console.WriteLine(word);
    }


// 7-Bir string dizisinin boyutunu dinamik olarak genişleten algoritmayı yazınız.

string[] names = new string[3] { "Ali", "Veli", "Melih" };

    Console.Write("Dizinin yeni boyutunu giriniz : ");
    int newSize = Convert.ToInt32(Console.ReadLine());

    Array.Resize(ref names, newSize);

    Console.WriteLine("Dizinin Yeni Boyutu : " + names.Length);

// 8-Kullanıcının girdiği kelimeleri listeye kaydeden ve tersten yazdıran algoritmayı yazınız
Console.WriteLine("Eğer çıkmak isterseniz değer girmeden enter tuşuna basınız ");
    Console.Write("Lütfen bir kelime giriniz : ");
    string word = Console.ReadLine();

    List<string> words = new List<string>();

    while (!string.IsNullOrEmpty(word))
    {
        words.Add(word);
        Console.Write("Lütfen bir kelime giriniz : ");
        word = Console.ReadLine();
    }

    words.Reverse();

    Console.WriteLine("Girilen Kelimelerin Ters Sıralaması : ");
    Console.Write(string.Join(",", words));

//9-Kullanıcıdan ratgele sayılar alıp listeye ekleyen,bu sayıların ortalamasını alan ve bu sayıları küçükten büyüğe sıralayan algoritmayı yazınız.

Console.WriteLine("Eğer çıkmak isterseniz 'close' yazıp Enter'a basınız.");

    List<int> randomNumbers = new List<int>();

    while (true)
    {
        Console.Write("Rastgele sayı eklemek için bir sayı giriniz : ");
        string input = Console.ReadLine();

        if (input == "close")
        {
            break;
        }

        if (int.TryParse(input, out int randomNumber)) // TryParse metodu ile kullanıcının girdiği değerin sayı olup olmadığını kontrol ediyoruz.Eğer burada Convert.ToInt32() işlemi yaparsak  kullanıcı sayı dışında bir değer girdiğinde program hata verecektir.
        {
            randomNumbers.Add(randomNumber);
        }
        else
        {
            Console.WriteLine("Lütfen geçerli bir sayı girin veya çıkmak için 'close' yazın.");
        }
    }

    int sum = 0;
    for (int i = 0; i < randomNumbers.Count; i++)
    {
        sum += randomNumbers[i];
    }
    int averageOfRandomNumbers = randomNumbers.Count > 0 ? sum / randomNumbers.Count : 0;


    randomNumbers.Sort();
    Console.WriteLine("Girilen Rastgele Sayıların Küçükten Büyüğe Sıralanmış Hali: " + string.Join(", ", randomNumbers));
    Console.WriteLine("Girilen Rastgele Sayıların Ortalama Değeri: " + averageOfRandomNumbers);


// 10-Bir sayı listesinde 10’dan küçük olanları silen algoritmayı yazınız.
List<int> numbersList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };


    int deleteNumber(int deletedNumberArea)
    {
        numbersList.RemoveAll(number => number < deletedNumberArea);
        return deletedNumberArea;
    }

    deleteNumber(5);

    Console.WriteLine(string.Join(",", numbersList));
    Console.WriteLine($"Listenin kalan eleman sayısı : {numbersList.Count}");


//11-Öğrenci notlarının olduğu bir listede 50’nin altındaki tüm notları 50 olarak güncelleyen bir algoritma yazınız.
    List<int> studentGrades = new List<int> { 45, 55, 65, 75, 85, 95, 35, 25, 15, 5, 95, 85, 75, 65, 55, 45, 35, 25, 15, 5 };
    studentGrades = studentGrades.Select(grade => grade < 50 ? 50 : grade).ToList();
    Console.WriteLine(string.Join(",", studentGrades));