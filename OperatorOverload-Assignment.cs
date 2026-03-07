using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorAssignment
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload == operator to compare Employee objects by their Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Handle case where both references point to the same object or both are null
            if (ReferenceEquals(emp1, emp2))
                return true;

            // Handle case where one is null and the other is not
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            // Compare the Id properties of both Employee objects
            return emp1.Id == emp2.Id;
        }

        // Overload != operator (required pair for ==)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Return the opposite of the == operator result
            return !(emp1 == emp2);
        }

        // Override Equals method for consistency with == operator
        public override bool Equals(object obj)
        {
            // Check if the object is null or not an Employee
            if (obj == null || GetType() != obj.GetType())
                return false;

            // Cast and compare Id values
            Employee emp = (Employee)obj;
            return Id == emp.Id;
        }

        // Override GetHashCode (required when overriding Equals)
        public override int GetHashCode()
        {
            // Return the hash code of the Id property
            return Id.GetHashCode();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Perform these actions and create a console app that includes the following:
             * Create an Employee class with Id, FirstName and LastName properties.
             * In the Employee class, overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property. 
             * Remember that comparison operators must be overloaded in pairs.
             * In the "Program.cs" file, instantiate two objects of the Employee class and assign values to their properties. 
             * Then compare the two Employee objects using the newly overloaded operators and display the results.
             * Add comments to each line or block of your code to explain what it does exactly, 
             * so that another developer could read and understand your code.
             * 
             */
            // Instantiate the first Employee object and assign values to its properties
            Employee employee1 = new Employee { Id = 1, FirstName = "Naseem", LastName = "Ganji" };
            // Instantiate the second Employee object and assign values to its properties
            Employee employee2 = new Employee { Id = 1, FirstName = "Mike", LastName = "Shaun" };
            // Compare the two Employee objects using the overloaded "==" operator and display the result
            
            if (employee1 == employee2)
            {
                Console.WriteLine("The two employees are considered equal based on their Id.");
            }
            else
            {
                Console.WriteLine("The two employees are not considered equal based on their Id.");
            }
            if (employee1.FirstName == employee2.FirstName)
            {
                Console.WriteLine("The two employees have the same first name.");
            }
            else
            {
                Console.WriteLine("The two employees have different first names.");
            }
            if (employee1.LastName == employee2.LastName)
            {
                Console.WriteLine("The two employees have the same last name.");
            }
            else
            {
                Console.WriteLine("The two employees have different last names.");
            }
            Console.WriteLine($"Employee 1: Id={employee1.Id}, FirstName= {employee1.FirstName}, LastName= {employee1.LastName}");
            Console.WriteLine($"Employee 2: Id={employee2.Id}, FirstName={employee2.FirstName}, LastName= {employee2.LastName}");

        }
    }
}
