
using System;

namespace OperatorsAssignment
{
    // This class represents an Employee with three properties.
    public class Employee
    {
        // Unique identifier for the employee.
        public int Id { get; set; } // Auto-implemented property for employee Id.

        // Employee's first name.
        public string FirstName { get; set; } // Auto-implemented property for first name.

        // Employee's last name.
        public string LastName { get; set; } // Auto-implemented property for last name.

        // Overload the == operator to compare two Employee instances by their Id values.
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both references point to the exact same object (or both are null), they are equal.
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If either side is null (but not both), they are not equal.
            if (emp1 is null || emp2 is null)
                return false;

            // Compare the Id properties to determine equality.
            return emp1.Id == emp2.Id;
        }

        // Overload the != operator as the logical negation of the == operator.
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Return the inverse of the == overload to keep operator semantics consistent.
            return !(emp1 == emp2);
        }

        // Override Equals(object) to match the semantics of the overloaded operators.
        public override bool Equals(object obj)
        {
            // Attempt to cast the incoming object to Employee.
            if (obj is Employee otherEmployee)
                // If the cast succeeds, compare Id values for equality.
                return this.Id == otherEmployee.Id;

            // If the incoming object is not an Employee, they are not equal.
            return false;
        }

        // Override GetHashCode when Equals is overridden to ensure consistent hash-based behavior.
        public override int GetHashCode()
        {
            // Use the hash code of the Id property as the object's hash code.
            return Id.GetHashCode();
        }
    }

    // The Program class contains the application's entry point.
    public static class Program
    {
        // The application's Main method: entry point when the program runs.
        public static void Main(string[] args)
        {
            // Instantiate the first Employee object and assign values to its properties.
            var employee1 = new Employee() // Create a new Employee instance and assign to variable employee1.
            {
                Id = 1, // Assign the unique identifier 1 to employee1.
                FirstName = "Alice", // Assign the first name "Alice".
                LastName = "Johnson" // Assign the last name "Johnson".
            };

            // Instantiate the second Employee object and assign values to its properties.
            var employee2 = new Employee() // Create a second Employee instance and assign to variable employee2.
            {
                Id = 1, // Assign the same unique identifier 1 to employee2 to demonstrate Id-based equality.
                FirstName = "Alicia", // Assign a different first name to show names are ignored in equality.
                LastName = "Johns" // Assign a different last name to show names are ignored in equality.
            };

            // Compare the two Employee objects using the overloaded == operator.
            bool areEqualUsingOperator = employee1 == employee2; // This calls the overloaded == operator.

            // Compare the two Employee objects using the overloaded != operator.
            bool areNotEqualUsingOperator = employee1 != employee2; // This calls the overloaded != operator.

            // Compare the two Employee objects using Equals(object) override.
            bool areEqualUsingEqualsMethod = employee1.Equals(employee2); // This calls Employee.Equals(object).

            // Show whether the two variables reference the exact same object in memory.
            bool areReferenceEqual = ReferenceEquals(employee1, employee2); // True only if both variables point to same instance.

            // Output the created Employee objects and comparison results to the console for confirmation.
            Console.WriteLine("Employee 1: Id={0}, FirstName={1}, LastName={2}", employee1.Id, employee1.FirstName, employee1.LastName);
            // Explain above: prints employee1 properties.
            Console.WriteLine("Employee 2: Id={0}, FirstName={1}, LastName={2}", employee2.Id, employee2.FirstName, employee2.LastName);
            // Explain above: prints employee2 properties.

            // Print the result of the overloaded == operator comparison.
            Console.WriteLine("employee1 == employee2: {0}", areEqualUsingOperator);
            // Print the result of the overloaded != operator comparison.
            Console.WriteLine("employee1 != employee2: {0}", areNotEqualUsingOperator);
            // Print the result of the Equals(object) method comparison.
            Console.WriteLine("employee1.Equals(employee2): {0}", areEqualUsingEqualsMethod);
            // Print whether both variables reference the exact same object.
            Console.WriteLine("ReferenceEquals(employee1, employee2): {0}", areReferenceEqual);

            // Wait for a key press before exiting so the console window remains open when run outside an IDE.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(); // Block until a key is pressed.
        }
    }
}
