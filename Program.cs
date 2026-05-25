bool runProgram = true;

while (runProgram)
{



    Console.WriteLine("\n--- Huvudmeny ---");
    Console.WriteLine("1. Ungdom eller pensionär");
    Console.WriteLine("2. Räkna pris för sällskap");
    Console.WriteLine("3. Upprepa tio gånger");
    Console.WriteLine("4. Det tredje ordet");
    Console.WriteLine("0. Avsluta");
    Console.Write("Välj: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            CheckAgePrice();
            break;

        case "2":
            CalculateGroupPrice();
            break;

        case "3":
            RepeatTenTimes();
            break;

        case "4":
            PrintThirdWord();
            break;

        case "0":
            runProgram = false;
            Console.WriteLine("Programmet avslutas.");
            break;

        default:
            Console.WriteLine("Felaktig input, försök igen.");
            break;
    }

}
    

    //first met
    static int GetPriceFromAge(int age)
{
    if (age < 20)
    {
        return 80;
    }
    else
    {
        if (age > 64)
        {
            return 90;
        }
        else
        {
            return 120;
        }
    }
}

//sec met
static void CheckAgePrice()
{
    Console.Write("Ange ålder: ");
    string input = Console.ReadLine();

    int age = int.Parse(input);
    int price = GetPriceFromAge(age);

    if (age < 20)
    {
        Console.WriteLine("Ungdomspris: 80kr");
    }
    else if (age > 64)
    {
        Console.WriteLine("Pensionärspris: 90kr");
    }
    else
    {
        Console.WriteLine("Standardpris: 120kr");
    }
}


//third met
static void CalculateGroupPrice()
{
    Console.Write("Hur många personer är ni? ");
    int numberOfPeople = int.Parse(Console.ReadLine());

    int totalPrice = 0;

    for (int i = 1; i <= numberOfPeople; i++)
    {
        Console.Write($"Ange ålder för person {i}: ");
        int age = int.Parse(Console.ReadLine());

        totalPrice += GetPriceFromAge(age);
    }

    Console.WriteLine($"Antal personer: {numberOfPeople}");
    Console.WriteLine($"Totalkostnad: {totalPrice}kr");
}

//fourth met
static void RepeatTenTimes()
{
    Console.Write("Skriv en text: ");
    string input = Console.ReadLine();

    for (int i = 1; i <= 10; i++)
    {
        Console.Write($"{i}. {input} ");
    }

    Console.WriteLine();
}

//
static void PrintThirdWord()
{
    Console.Write("Skriv en mening med minst tre ord: ");
    string sentence = Console.ReadLine();

    string[] words = sentence.Split(' ');

    Console.WriteLine($"Det tredje ordet är: {words[2]}");
}