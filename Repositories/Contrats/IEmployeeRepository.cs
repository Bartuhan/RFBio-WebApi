using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contrats
{
    public interface IEmployeeRepository : IRepositoryBase<Employee>
    {
        IQueryable<Employee> GetAllEmployee(bool trackChanges);
        Employee GetEmployeeByID(int id, bool trackChanges);
        void CreateEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
    }
}
