// See https://aka.ms/new-console-template for more information

Run();

void Run()
{
    var usersFavoriteAnimals = ReadPets(new List<string>(), 0);

    Console.WriteLine("Namnen på dina favorit djur är?");

    foreach (var petName in usersFavoriteAnimals)
    {
        Console.Write($"{petName}, ");
    }

    Console.WriteLine("vill du sluta?");

    var read = Console.ReadLine();
    if (read == "y")
    {

    }
    else
    {
        Console.Clear();
        Run();
    }

}

List<string> ReadPets(List<string> currentPets, int numberCalls)
{
    //Skapar en ny lista  

    if (IsFirstCall(numberCalls))
    {
        Console.WriteLine("Hej och välkommen till djurens vänner ange namnet på ett djur du gillar:");
    }
    else
    {
        Console.WriteLine("Skriv in ett namn till:");
    }

    var petName = Console.ReadLine();

    if (petName != null)
    {
        currentPets.Add(petName);
    }

    Console.WriteLine("Vill du skriva in ett namn till?:");


    if (Console.ReadLine() == "y")
    {
        return ReadPets(currentPets, numberCalls + 1);
    }

    return currentPets;
}


bool IsFirstCall(int noOfCalls)
{
    return noOfCalls == 0;
}