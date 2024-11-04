using System;

namespace EmployeeComparisonApp
{
    // Define the Employee class
    public class Employee
    {
        // Properties for the Employee's ID, first name, and last name
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the == operator to compare Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both objects are null or if they are the same object in memory
            if (ReferenceEquals(emp1, emp2))
                return true;

            // Check if either object is null
            if (emp1 is null || emp2 is null)
                return false;

            // Compare the Id properties of both Employee objects
            return emp1.Id == emp2.Id;
        }

        // Overload the != operator to compare Employee objects by Id
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2); // Use the result of the == operator to determine !=
        }

        // Override the Equals method (recommended when overloading ==)
        public override bool Equals(object obj)
        {
            // Check if obj is an Employee and compare Id if so
            if (obj is Employee otherEmployee)
                return this.Id == otherEmployee.Id;

            return false;
        }

        // Override GetHashCode (recommended when overloading ==)
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
