﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using EmployeeManagement.Web.Models;

namespace EmployeeManagement.Web.Pages
{
    public class EditEmployeeBase : ComponentBase
    {
        public Employee Employee { get; set; } = new Employee();
        public EditEmployeeModel EditEmployeeModel { get; set; } = new EditEmployeeModel();

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        [Parameter]
        public string Id { get; set; }

        [Inject]
        public IDepartmentService DepartmentService { get; set; }
        public IEnumerable<Department> Departments { get; set; }
     //   public string DepartmentId { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeService.GetEmployee(int.Parse(Id));
           
          //  DepartmentId = Employee.DepartmentId.ToString();

            Departments = await DepartmentService.GetDepartments();

            EditEmployeeModel.EmployeeId = Employee.EmployeeId;
            EditEmployeeModel.FirstName = Employee.FirstName;
            EditEmployeeModel.LastName = Employee.LastName;
            EditEmployeeModel.Email = Employee.Email;
            EditEmployeeModel.EmailConfirm = Employee.Email;
            EditEmployeeModel.DateOfBirth = Employee.DateOfBirth;
            EditEmployeeModel.Gender = Employee.Gender;
            EditEmployeeModel.DepartmentId = Employee.DepartmentId;
            EditEmployeeModel.Department = Employee.Department;
            EditEmployeeModel.PhotoPath = Employee.PhotoPath;

        }
        public void HandleValidSubmit() { }
    }
}
