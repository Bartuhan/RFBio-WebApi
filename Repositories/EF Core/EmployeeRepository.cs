using Entities.Models;
using Repositories.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EF_Core
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateEmployee(Employee employee) => Create(employee);

        public void DeleteEmployee(Employee employee) => Delete(employee);

        public void UpdateEmployee(Employee employee) => Update(employee);

        public IQueryable<Employee> GetAllEmployee(bool trackChanges) => 
            FindAll(trackChanges).OrderBy(x => x.EmployeeId);

        public Employee GetEmployeeByID(int id, bool trackChanges) =>
            FindByConditions(x => x.EmployeeId.Equals(id) , trackChanges)
            .SingleOrDefault();
    }
}
