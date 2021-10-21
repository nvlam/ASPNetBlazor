﻿using Microsoft.AspNetCore.Components;
using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Web.Services;

namespace EmployeeManagement.Web
{
    public class EmployeeListBase:ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        public bool ShowFooter { get; set; } = true;
        protected int SelectedEmployeeCount { get; set; } = 0;
        protected override async Task OnInitializedAsync()
        {
            // await Task.Run(LoadEmployees);
            // return base.OnInitializedAsync();
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }

        protected void EmployeeSelectionChanged(bool isSelected)
        {
            if (isSelected)
            {
                SelectedEmployeeCount++;
            }
            else
            { SelectedEmployeeCount--;
            }
        }

        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(5000);
            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Hastings",
                Email = "David@pragimtech.com",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                //  Department = new Department { DepartmentId = 1, DepartmentName = "IT" },
                DepartmentId = 1,
                PhotoPath = "images/john.png"
            };

        Employee e2 = new Employee
        {
            EmployeeId = 2,
            FirstName = "Sam",
            LastName = "Galloway",
            Email = "Sam@pragimtech.com",
            DateOfBirth = new DateTime(1981, 12, 22),
            Gender = Gender.Male,
            //   Department = new Department { DepartmentId = 2, DepartmentName = "HR" },
            DepartmentId = 2,
                PhotoPath = "images/sam.jpg"
            };

            Employee e3 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Mary",
                LastName = "Smith",
                Email = "mary@pragimtech.com",
                DateOfBirth = new DateTime(1979, 11, 11),
                Gender = Gender.Female,
                // Department = new Department { DepartmentId = 1, DepartmentName = "IT" },
                DepartmentId = 2,
            PhotoPath = "images/mary.png"
            };

            Employee e4 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Sara",
                LastName = "Longway",
                Email = "sara@pragimtech.com",
                DateOfBirth = new DateTime(1982, 9, 23),
                Gender = Gender.Female,
                // Department = new Department { DepartmentId = 3, DepartmentName = "Payroll" },
                DepartmentId = 2,
            PhotoPath = "images/sara.png"
            };

            Employees = new List<Employee> { e1, e2, e3, e4 };
        }
    }
}
