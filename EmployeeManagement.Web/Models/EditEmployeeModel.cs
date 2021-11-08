using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;

using EmployeeManagement.Models.CustomValidators;



namespace EmployeeManagement.Web.Models
{
    public class EditEmployeeModel
    {

        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Tên bắt buộc phải nhập")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Tên tối đa 100 ký tự, tối thiểu 2 ký tự")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Họ bắt buộc phải nhập")]
        public string LastName { get; set; }


        [EmailDomainValidator(AllowedDomain = "kgc.edu.vn", ErrorMessage = "Chi nhan email tu kgc.edu.vn")]
        public string Email { get; set; }

        [CompareAttribute("Email",
        ErrorMessage = "Email and Confirm Email must match")]
        public string EmailConfirm { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        // public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public string PhotoPath { get; set; }

        [ValidateComplexType]
        public Department Department { get; set; } = new Department();
    }
}
