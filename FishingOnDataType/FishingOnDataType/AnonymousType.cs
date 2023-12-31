﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingOnDataType
{
    public class AnonymousType
    {
        public void Print()
        {
            var Student = new
            {
                Id = 17344181,
                Name = "Nazib Mahfuz",
                Department = "Computer Science & Engineering"
            };

            Console.WriteLine(Student);

            Console.WriteLine($"Student Id         : {Student.Id}");
            Console.WriteLine($"Student Name       : {Student.Name}");
            Console.WriteLine($"Student Department : {Student.Department}");
        }

        public void NestedAnonymousPrint()
        {
            var Employee = new
            {
                EmployeeId = "0009008",
                EmployeeName = "Nazib Mahfuz",
                EmployeeEmail = "nazib.m@hsenidbiz.com",
                Designation = "Software Engineer",
                Equipment = new
                {
                    Id = 1,
                    Name = "Laptop",
                    Model = "HP",
                    Price = 55000,
                    Currency = "BDT"
                }
            };

            Console.WriteLine("Print Nested Anonymouse");
            Console.WriteLine("Employee Information");
            Console.WriteLine($"Emp Id : {Employee.EmployeeId}");
            Console.WriteLine($"Emp Id : {Employee.EmployeeName}");
            Console.WriteLine("Employee Equipment Print");
            Console.WriteLine($"Device Type : {Employee.Equipment.Name}");
            Console.WriteLine($"Device Type : {Employee.Equipment.Model}");
            Console.WriteLine($"Device Type : {Employee.Equipment.Price}");
            Console.WriteLine($"Device Type : {Employee.Equipment.Currency}");
        }
    }
}
