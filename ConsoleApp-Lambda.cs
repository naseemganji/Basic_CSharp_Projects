using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp_lambda
{
    public class Employee
    {
        // Define the properties of the Employee class
        public int Id { get; set; } // Employee ID
        public string FirstName { get; set; } // Employee's first name
        public string LastName { get; set; } // Employee's last name
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Perform these actions and create a console app that includes the following:
             * Create an Employee class with the following properties:
             * a. Id
             * b. First Name
             * c. Last Name
             * In the Main() method, create a list of at least 10 employees. 
             * At least two employees should have the first name “Joe”.
             * Using a foreach loop, create a new list of all employees with the first name “Joe”. 
             * In your comparison statement, remember to reference the property of the object you are checking.
             * Perform the same action again, but this time with a lambda expression.
             * Using a lambda expression, make a list of all employees with an Id number greater than 5.
             * Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.
             *  
             */
            // Create a list of employees and add 10 employees to the list
            Console.WriteLine(
                "Creating a list of employees and adding 10 employees to the list...");
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Id = 1, FirstName = "Joe", LastName = "Smith" });
            employees.Add(new Employee() { Id = 2, FirstName = "Jane", LastName = "Doe" });
            employees.Add(new Employee() { Id = 3, FirstName = "John", LastName = "Doe" });
            employees.Add(new Employee() { Id = 4, FirstName = "Joe", LastName = "Johnson" });
            employees.Add(new Employee() { Id = 5, FirstName = "Jack", LastName = "Smith" });
            employees.Add(new Employee() { Id = 6, FirstName = "Jill", LastName = "Doe" });
            employees.Add(new Employee() { Id = 7, FirstName = "Jim", LastName = "Smith" });
            employees.Add(new Employee() { Id = 8, FirstName = "Jane", LastName = "Smith" });
            employees.Add(new Employee() { Id = 9, FirstName = "John", LastName = "Smith" });
            employees.Add(new Employee() { Id = 10, FirstName = "Jack", LastName = "Doe" });

            foreach (Employee employee in employees)
            {
                // Check if the employee's first name is "Joe"
                if (employee.FirstName == "Joe")
                {
                    // If it is, add the employee to the list of employees named Joe
                    Console.WriteLine("Adding employee with first name 'Joe' to the list of employees named Joe...");
                    List<Employee> joes = new List<Employee>();
                    joes.Add(employee);

                }
            }

            // Using a lambda expression to find all employees named "Joe"
            List<Employee> joesLambda = employees.Where(x => x.FirstName == "Joe").ToList();
            Console.WriteLine("Employees named 'Joe' using lambda expression:");
            foreach (Employee joe in joesLambda)
            {
                Console.WriteLine($"{joe.FirstName} {joe.LastName}");
            }

        }
    }
}
