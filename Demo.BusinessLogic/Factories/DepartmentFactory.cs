using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Demo.BusinessLogic.DataTransferObject;
using Demo.DataAccess.Models;

namespace Demo.BusinessLogic.Factories
{
    static class DepartmentFactory
    {
        public static DepartmentDto ToDepartmentDto(this Department D)
        {
            return new DepartmentDto()
            {
                DeptId = D.Id,
                Code = D.Code,
                Description = D.Description,
                Name = D.Name,
                DateOfCreation = DateOnly.FromDateTime(D.CreatedOn)

            };
        }
        public static DepartmentDetialsDto ToDepartmentDetialsDto(this Department department)
        {
            return new DepartmentDetialsDto()
            {
                Id = department.Id,
                Name = department.Name,
                CreatedOn = DateOnly.FromDateTime(department.CreatedOn)
            };
        }
    
        public static  Department ToEntity(this CreatedDepartmentDto departmentDto)
        {
            return new Department()
            {
                Name = departmentDto.Name,
                Code = departmentDto.Code,
                Description = departmentDto.Description,
                CreatedOn = departmentDto.DateOfCreation.ToDateTime( new TimeOnly())
            };
        }

        public static Department ToEntity(this UpdatedDepartmentDto departmentDto) => new Department()
        {
            Id = departmentDto.Id,
            Name = departmentDto.Name,
            Code = departmentDto.Code,
            CreatedOn = departmentDto.DateOfCreation.ToDateTime(new TimeOnly()),
            Description = departmentDto.Description,
        };
    } 
}
