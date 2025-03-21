using Demo.BusinessLogic.DataTransferObject;

namespace Demo.BusinessLogic.Services
{
    public interface IDepartmentServices
    {
        int AddDepartment(CreatedDepartmentDto departmentDto);
        bool DeleteDepartment(int id);
        IEnumerable<DepartmentDto> GetAllDepartments();
        DepartmentDetialsDto? GetDepartmentById(int id);
        int UpdatedDepartment(UpdatedDepartmentDto departmentDto);
    }
}