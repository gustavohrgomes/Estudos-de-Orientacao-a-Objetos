﻿using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListasExercicio {
    class Program {
        static void Main(string[] args) {

            Console.Write("How many employees will be registered? ");
            int employeeQuantity = int.Parse(Console.ReadLine());

            List<Employee> employeeList = new List<Employee>();

            for (int i = 1; i <= employeeQuantity; i++) {

                Console.WriteLine($"Employee #{i}: ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employeeList.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase:");
            int searchId = int.Parse(Console.ReadLine());
            Employee employee = employeeList.Find(x => x.Id == searchId);
            if (employee != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employee.IncreaseSalary(percentage);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in employeeList) {
                Console.WriteLine(obj);
            }
        }
    }
}