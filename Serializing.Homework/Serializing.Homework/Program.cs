using Serializing.Homework.Models;
using Serializing.Homework.Services;

Console.WriteLine("Enter 1 to list all dogs and 2 to enter a new dog");

string userOption = Console.ReadLine();

if (userOption == "1")
{
    List<Dog> dogs = DogService.GetDogs();
    PrintDogs(dogs);
}
else if (userOption == "2")
{
    Console.WriteLine("Enter your dogs name");
    string dogName = Console.ReadLine();

    Console.WriteLine("Enter your dogs current age");
    int dogCurrentAge = int.Parse(Console.ReadLine());
    DateTime dogDateOfBirth = DateTime.Now.AddYears(dogCurrentAge * -1);

    Console.WriteLine("Select color:\n0 - Black\n1 - White\n2 - Gray\n3 - Brown\n4 - Blonde\n5 - Gold\n6 - Spotted");
    int colorNumber = int.Parse(Console.ReadLine());
    if(colorNumber < 0 || colorNumber > 6)
    {
        Console.WriteLine("Number is not an option");
        return;
    }
    DogColor dogColor = (DogColor)colorNumber;

    Dog dogToAdd = new Dog(dogName, dogDateOfBirth, dogColor);
    try
    {
        DogService.SaveDog(dogToAdd);
        Console.WriteLine("New dog was added Successfully");
        Console.WriteLine("===== New List =====");
        var dogs = DogService.GetDogs();
        PrintDogs(dogs);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
else
{
    Console.WriteLine("Option not recognized");
}

void PrintDogs(List<Dog> dogs)
{
    if (dogs.Count == 0)
    {
        Console.WriteLine("There are no dogs added");
    }
    dogs.ForEach(x => Console.WriteLine($"{x.Name} Color:{x.Color} - {x.GetAge()} years old"));
}