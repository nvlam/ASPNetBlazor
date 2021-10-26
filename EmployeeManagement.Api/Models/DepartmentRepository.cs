using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext appDbContext;
        public DepartmentRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Department> GetDepartment(int departmentId)
        {
            return await appDbContext.Departments.
                FirstOrDefaultAsync(d => d.DepartmentId == departmentId);
           
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await appDbContext.Departments.ToListAsync();
        }

        public async Task<Department> AddDepartment(Department department)
        {
            var result = await appDbContext.Departments.AddAsync(department);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Department> DeleteDepartment(int departmentId)
        {
            var result = await appDbContext.Departments
              .FirstOrDefaultAsync(e => e.DepartmentId== departmentId);
            if (result != null)
            {
                appDbContext.Departments.Remove(result);
                await appDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<IEnumerable<Department>> Search(string name)
        {
            IQueryable<Department> query = appDbContext.Departments;

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.DepartmentName.Contains(name));
            }
           
            return await query.ToListAsync();
        }

        public async Task<Department> UpdateDepartment(Department department)
        {
            var result = await appDbContext.Departments
                .FirstOrDefaultAsync(e => e.DepartmentId == department.DepartmentId);
            if (result != null)
            {
                result.DepartmentName = department.DepartmentName;
                await appDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
