using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.DataAccess.Data.Contexts;
using Demo.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.DataAccess.Repositories
{
    public class DepartmentRepository(ApplicationDbContext dbContext) : IDepartmentRepository
    {
        private readonly ApplicationDbContext _dbcontex = dbContext;

        //CRUD OPERATIONS

        // Get all
        public IEnumerable<Department> GetAll(bool WithTracking = false)
        {
            {
                if (WithTracking)
                    return _dbcontex.Departments.ToList();
                else return _dbcontex.Departments.AsNoTracking().ToList();
            }
        }

        //Get By ID
        public Department? GetById(int id) => _dbcontex.Departments.Find(id);
        //update
        public int Update(Department department)
        {
            {
                _dbcontex.Departments.Update(department);
                return _dbcontex.SaveChanges();
            }
        }
        //Delete
        public int Remove(Department department)
        {
            _dbcontex.Departments.Remove(department);
            return _dbcontex.SaveChanges();
        }
        //insert
        public int Add(Department department)
        {
            _dbcontex.Departments.Add(department);
            return _dbcontex.SaveChanges();
        }
    }
}
