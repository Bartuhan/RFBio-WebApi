using Repositories.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EF_Core
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly Lazy<IEmployeeRepository> _employeeRepository;
        private readonly Lazy<IEmployeeCardRepository> _employeeCardRepository;

        public RepositoryManager(RepositoryContext context ) 
        { 
            _context = context;
            _employeeRepository = new Lazy<IEmployeeRepository>(() => new EmployeeRepository(_context));
            _employeeCardRepository = new Lazy<IEmployeeCardRepository>(() => new EmployeeCardRepository(_context));
        }

        public IEmployeeRepository Employee => _employeeRepository.Value;

        public IEmployeeCardRepository EmployeeCard => _employeeCardRepository.Value;

        public void Save()
        {
           _context.SaveChanges();
        }
    }
}
