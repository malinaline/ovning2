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
    

    