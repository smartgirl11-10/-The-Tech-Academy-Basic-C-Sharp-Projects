
using System;

namespace PolymorphismAssignment
{
    // This interface defines a contract that any implementing class must follow.
    // It requires a Quit() method with no return type.
    public interface IQuittable
    {o
        void Quit();
    }

    // This Employee class inherits from the IQuittable interface.
    // That means it MUST implement the Quit() method.
    public class Employee : IQuittable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // This method fulfills the interface requirement.
        // It can perform any action you choose.
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} has quit the job.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object and assign values to its properties.
            Employee emp = new Employee()
            {
                FirstName = "John",
                LastName = "Doe"
            };

            // POLYMORPHISM:
            // Create an object of type IQuittable but assign it an Employee instance.
            // This works because Employee implements IQuittable.
            IQuittable quittableEmployee = emp;

            // Call the Quit() method using the interface reference.
            quittableEmployee.Quit();

            // Keep the console window open until a key is pressed.
            Console.ReadLine();
        }
    }
}
