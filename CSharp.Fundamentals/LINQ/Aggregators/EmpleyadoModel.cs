﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Fundamentals.LINQ.Aggregators
{
    /// <summary>
    /// The Employee Model
    /// </summary>
    public class EmpleyadoModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }

        public static List<EmpleyadoModel> GetAllEmployees()
        {
            List<EmpleyadoModel> listStudents = new List<EmpleyadoModel>()
            {
                new EmpleyadoModel{ID= 101,Name = "Preety", Salary = 10000, Department = "IT"},
                new EmpleyadoModel{ID= 102,Name = "Priyanka", Salary = 15000, Department = "Sales"},
                new EmpleyadoModel{ID= 103,Name = "James", Salary = 50000, Department = "Sales"},
                new EmpleyadoModel{ID= 104,Name = "Hina", Salary = 20000, Department = "IT"},
                new EmpleyadoModel{ID= 105,Name = "Anurag", Salary = 30000, Department = "IT"},
                new EmpleyadoModel{ID= 106,Name = "Sara", Salary = 25000, Department = "IT"},
                new EmpleyadoModel{ID= 107,Name = "Pranaya", Salary = 35000, Department = "IT"},
                new EmpleyadoModel{ID= 108,Name = "Manoj", Salary = 11000, Department = "Sales"},
                new EmpleyadoModel{ID= 109,Name = "Sam", Salary = 45000, Department = "Sales"},
                new EmpleyadoModel{ID= 110,Name = "Saurav", Salary = 25000, Department = "Sales"}
            };

            return listStudents;
        }
    }
}