using System;

namespace EmployeeComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first Employee object and assign values to its properties
            Employee employee1 = new Employee
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };

            // Create the second Employee object and assign values to its properties
            Employee employee2 = new Employee
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Smith"
            };

            // Use the overloaded == operator to compare the two Employee objects
            bool areEqual = employee1 == employee2;
            Console.WriteLine($"Are Employee 1 and Employee 2 equal? {areEqual}");

            // Use the overloaded != operator to compare the two Employee objects
            bool areNotEqual = employee1 != employee2;
            Console.WriteLine($"Are Employee 1 and Employee 2 not equal? {areNotEqual}");

            // Pause to allow the user to see the output before the program closes
            Console.ReadKey();
        }
    }
}
