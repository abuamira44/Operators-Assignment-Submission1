using System;

// Create an Employee class with Id, FirstName, and LastName properties
public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overload the "==" operator to compare Employee objects based on their Id property
    public static bool operator ==(Employee employee1, Employee employee2)
    {
        // Check if both objects are null or if their Id properties are equal
        return ReferenceEquals(employee1, null) && ReferenceEquals(employee2, null) ||
               !ReferenceEquals(employee1, null) && !ReferenceEquals(employee2, null) && employee1.Id == employee2.Id;
    }

    // Overload the "!=" operator to complement the "==" operator
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        return !(employee1 == employee2);
    }
}

class Program
{
    static void Main()
    {
        // Instantiate two objects of the Employee class and assign values to their properties
        Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
        Employee employee2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" };

        // Compare the two Employee objects using the overloaded operators and display the results
        Console.WriteLine($"Are employees equal? {employee1 == employee2}");
        Console.WriteLine($"Are employees not equal? {employee1 != employee2}");
    }
}



