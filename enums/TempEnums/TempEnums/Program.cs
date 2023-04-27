﻿using System;
using System.Globalization;
using TempEnums.Entities;
using TempEnums.Entities.Enums;

namespace TempEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base Salary: ");
            double baseSalary = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, department);

            Console.WriteLine();

            Console.Write("How many contracts to this worker: ");
            int opt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= opt; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (Hours): ");
                int hours = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = Convert.ToInt32(monthAndYear.Substring(0, 2));
            int year = Convert.ToInt32(monthAndYear.Substring(3));

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month).ToString("F2")}");

        }
    }
}