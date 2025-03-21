using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.BusinessLogic.DataTransferObject;
using Demo.BusinessLogic.Factories;
using Demo.DataAccess.Repositories;

namespace Demo.BusinessLogic.Services
{
   public class DepartmentServices(IDepartmentRepository _departmentRepository) : IDepartmentServices
    {
        // Get all Departments
        public IEnumerable<DepartmentDto> GetAllDepartments()
        {
            var departments = _departmentRepository.GetAll();
            return departments.Select(D => D.ToDepartmentDto());

        }
        //Get Department BY ID
        public DepartmentDetialsDto? GetDepartmentById(int id)
        {
            var department = _departmentRepository.GetById(id);
            return department is null ? null : department.ToDepartmentDetialsDto();
        }
        //create New Department
        public int AddDepartment(CreatedDepartmentDto departmentDto)
        {
            var departmnet = departmentDto.ToEntity();
            return _departmentRepository.Add(departmnet);
        }
        // update Department
        public int UpdatedDepartment(UpdatedDepartmentDto departmentDto)
        {
            return _departmentRepository.Update(departmentDto.ToEntity());

        }
        // Delete Department
        public bool DeleteDepartment(int id)
        {
            var Department = _departmentRepository.GetById(id);
            if (Department is null) return false;
            else
            {
                int Result = _departmentRepository.Remove(Department);
                return Result > 0 ? true : false;
            }
        }
    }
}
