using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contrats
{
    public interface IEmployeeCardRepository : IRepositoryBase<EmployeeCard>
    {
        IQueryable<EmployeeCard> GetAllEmployeeCard(bool trackChanges);
        EmployeeCard GetEmployeeCardByID(int id, bool trackChanges);
        void CreateEmployeeCard(EmployeeCard employeeCard);
        void UpdateEmployeeCard(EmployeeCard employeeCard);
        void DeleteEmployeeCard(EmployeeCard employeeCard);
    }
}
