using Entities.Models;
using Repositories.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EF_Core
{
    public class EmployeeCardRepository : RepositoryBase<EmployeeCard>, IEmployeeCardRepository
    {
        public EmployeeCardRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateEmployeeCard(EmployeeCard employeeCard) => Create(employeeCard);

        public void UpdateEmployeeCard(EmployeeCard employeeCard) =>Update(employeeCard);
       
        public void DeleteEmployeeCard(EmployeeCard employeeCard) => Delete(employeeCard);

        public IQueryable<EmployeeCard> GetAllEmployeeCard(bool trackChanges) => 
            FindAll(trackChanges).OrderBy(x => x.Id);
        
        public EmployeeCard GetEmployeeCardByID(int id, bool trackChanges) =>
            FindByConditions(x => x.Id.Equals(id), trackChanges).SingleOrDefault();
    }
}
