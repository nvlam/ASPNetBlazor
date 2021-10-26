using EmployeeManagement.Api.Models;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepository departmentRepository;
        public DepartmentsController(IDepartmentRepository departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Department>>> GetDepartments()
        {
            try
            {
                return (await departmentRepository.GetDepartments()).ToList();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Department>> GetDepartment(int id)
        {
            try
            {
                var result = await departmentRepository.GetDepartment(id);
                if (result == null)
                    return NotFound();

                return result;


            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Loi tu server");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Department>> CreateDepartment(Department department)
        {
            try
            {
                if (department == null)
                    return BadRequest();

             
                var createdDepartment = await departmentRepository.AddDepartment(department);

                return CreatedAtAction(nameof(GetDepartment),
                    new { id = createdDepartment.DepartmentId }, createdDepartment);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Loi khi tao department moi");
            }

        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Department>> UpdateEmployee(int id, Department department)
        {
            try
            {
                if (id != department.DepartmentId)
                    return BadRequest("Ma so Phong/Ban khong khop");

                var departmentToUpdate = await departmentRepository.GetDepartment(id);
                if (departmentToUpdate == null)
                    return NotFound($"KHong tim thay Department voi Id= {id}");

                return await departmentRepository.UpdateDepartment(department);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                     "Loi khi Cap nhat Department");
            }
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Department>> DeleteDepartment(int id)
        {
            try
            {
                var departmentToDelete = await departmentRepository.GetDepartment(id);
                if (departmentToDelete == null)
                    return NotFound($"Khong tim thay Department co Id={id}");

                return await departmentRepository.DeleteDepartment(id);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                      "Loi khi xoa Department");
            }
        }

        [HttpGet("{search}")]
        public async Task<ActionResult<IEnumerable<Department>>> Search(string name)
        {
            try
            {
                var result = await departmentRepository.Search(name);

                if (result.Any())
                {
                    return Ok(result);
                }

                return NotFound();

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                       "Loi khi lay du lieu tu CSDL");
            }
        }
    }
}
