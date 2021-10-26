using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int departmentId);
        Task<Department> AddDepartment(Department department);
        Task<Department> UpdateDepartment(Department department);

        Task<Department> DeleteDepartment(int departmentId);
        Task<IEnumerable<Department>> Search(string name);
    }
}
