﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine("Sum: ");
            Console.WriteLine(numbers.Sum());
            Console.WriteLine("----------------------");

            //TODO: Print the Average of numbers
            Console.WriteLine("Average: ");
            Console.WriteLine(numbers.Average());
            Console.WriteLine("----------------------");

            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("Numbers in ascending order");
            numbers.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("----------------------");

            //TODO: Order numbers in decsending order adn print to the console
            Console.WriteLine("Numbers in descending order");
            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("----------------------");

            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Numbers greater than 6");
            numbers.Where(x => x > 6).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("----------------------");

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Top 4");
            var list = numbers.OrderBy(x => x).ToList();
            foreach(var item in list.Take(4))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------");

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            Console.WriteLine("My age first then numbers is decsending order");
            numbers[4] = 25;
            numbers.OrderByDescending(numbers => numbers).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("----------------------");

            // List of employees ****Do not remove this****

            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName.
            Console.WriteLine("Employees that start with \"C\" or \"S\"");
            employees.Where(x => x.FirstName.StartsWith('C') || x.FirstName.StartsWith('S'))
                .OrderBy(x => x.FirstName)
                .ToList().ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine("----------------------");

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("Employees over 26: ");
            employees.Where(x => x.Age > 26)
                .OrderBy(x => x.Age).ThenBy(x => x.FirstName)
                .ToList().ForEach(x => Console.WriteLine(x.FullName));

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35
            var total = employees.Where(x => x.Age > 35 && x.YearsOfExperience <= 10).Sum(x => x.YearsOfExperience);
            var average = employees.Where(x => x.Age > 35 && x.YearsOfExperience <= 10).Average(x => x.YearsOfExperience);
            Console.WriteLine(total);
            Console.WriteLine(average);

            //TODO: Add an employee to the end of the list without using employees.Add()

            employees.Append(new Employee("Douglas", "Powers", 40, 28));

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
