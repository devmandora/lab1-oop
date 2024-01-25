using System;
using System.Collections.Generic;

// Person class definition
public class Person
{
    public int PersonId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FavoriteColour { get; set; }
    public int Age { get; set; }
    public bool IsWorking { get; set; }

    // DisplayPersonInfo method
    public void DisplayPersonInfo()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}\n" +
                          $"PersonId: {PersonId}\n" +
                          $"Favorite colour is: {FavoriteColour}");
    }

    // ChangeFavoriteColour method
    public void ChangeFavoriteColour()
    {
        FavoriteColour = "White";
        Console.WriteLine($"{FirstName} {LastName}'s favorite colour is: {FavoriteColour}");
    }

    // GetAgeInTenYears method
    public int GetAgeInTenYears()
    {
        return Age + 10;
    }

    // ToString method
    public override string ToString()
    {
        return $"PersonId: {PersonId}\n" +
               $"FirstName: {FirstName}\n" +
               $"LastName: {LastName}\n" +
               $"FavoriteColour: {FavoriteColour}\n" +
               $"Age: {Age}\n" +
               $"IsWorking: {IsWorking}";
    }
}

// Relation class definition
public class Relation
{
    public string RelationshipType { get; set; }

    // ShowRelationShip method
    public void ShowRelationShip(Person person1, Person person2)
    {
        Console.WriteLine($"Relationship between {person1.FirstName} and {person2.FirstName} is: {RelationshipType}");
    }
}

// Main class
class Program
{
    static void Main()
    {
        // Creating four Person objects
        Person person1 = new Person { PersonId = 1, FirstName = "Ian", LastName = "Brooks", FavoriteColour = "White", Age = 30, IsWorking = true };
        Person person2 = new Person { PersonId = 2, FirstName = "Gina", LastName = "James", FavoriteColour = "Green", Age = 18, IsWorking = false };
        Person person3 = new Person { PersonId = 3, FirstName = "Mike", LastName = "Briscoe", FavoriteColour = "Blue", Age = 45, IsWorking = true };
        Person person4 = new Person { PersonId = 4, FirstName = "Mary", LastName = "Beals", FavoriteColour = "Yellow", Age = 28, IsWorking = true };

        // Displaying Gina’s information
        Console.WriteLine($"{person2.PersonId}: {person2.FirstName} {person2.LastName}'s favorite colour is {person2.FavoriteColour}");

        // Displaying all of Mike’s information
        Console.WriteLine(person3);

        // Changing Ian’s Favorite Colour to white
        Console.WriteLine($"{person1.PersonId}: {person1.FirstName} {person1.LastName}'s favorite colour is {person1.FavoriteColour}");

        // Displaying Mary’s age after ten years
        Console.WriteLine($"{person4.FirstName} {person4.LastName}'s Age in 10 years is: {person4.GetAgeInTenYears()}");
        Console.WriteLine(person3);
        // Creating two Relation objects
        Relation relation1 = new Relation { RelationshipType = "Sisterhood" };
        Relation relation2 = new Relation { RelationshipType = "Brotherhood" };

        // Displaying both relationships
        relation1.ShowRelationShip(person2, person4);
        relation2.ShowRelationShip(person1, person3);

        // Adding all Person objects to a list
        List<Person> peopleList = new List<Person> { person1, person2, person3, person4 };

        // Calculating and displaying average age
        double averageAge = peopleList.Average(person => person.Age);
        Console.WriteLine($"Average age is: {averageAge:F2}");

        // Finding the youngest and oldest person
        Person youngestPerson = peopleList.OrderBy(person => person.Age).First();
        Person oldestPerson = peopleList.OrderByDescending(person => person.Age).First();
        Console.WriteLine($"The youngest person is: {youngestPerson.FirstName}");
        Console.WriteLine($"The oldest person is: {oldestPerson.FirstName}");

        // Displaying the names of the people whose first names start with M
        List<Person> MNames = peopleList.FindAll(person => person.FirstName.StartsWith("M"));
        foreach (var person in MNames)
        {
            Console.WriteLine(person);
        }
    }
}