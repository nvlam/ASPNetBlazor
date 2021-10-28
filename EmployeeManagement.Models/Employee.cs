using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
   public class Employee
    {
        public int EmployeeId { get; set; }

       [Required(ErrorMessage ="Tên bắt buộc phải nhập")]
       [StringLength(100, MinimumLength =2,ErrorMessage ="Tên tối đa 100 ký tự, tối thiểu 2 ký tự")]
        public string FirstName { get; set; }

       [Required(ErrorMessage = "Họ bắt buộc phải nhập")]
        public string LastName { get; set; }

       [EmailAddress(ErrorMessage ="Nhập email phải đúng định dạng")]
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
       // public Department Department { get; set; }
       public int DepartmentId { get; set; }
        public string PhotoPath { get; set; }
        public Department Department { get; set; }
    }

    
}

