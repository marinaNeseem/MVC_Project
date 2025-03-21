using Demo.DataAccess.Models;

namespace Demo.DataAccess.Repositories
{
    public interface IDepartmentRepository
    {
        int Add(Department department);
        IEnumerable<Department> GetAll(bool WithTracking = false);
        Department? GetById(int id);
        
        int Update(Department department);
        int Remove(Department department);
    }
}