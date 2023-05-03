using Repositories.Contrats;
using Services.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IEmployeeService> _employeeSerivice;
        private readonly Lazy<IEmployeeCardService> _employeeCardService;
        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _employeeSerivice = new Lazy<IEmployeeService>(() => new EmployeeManager(repositoryManager));
            _employeeCardService = new Lazy<IEmployeeCardService>(() => new EmployeCardManager(repositoryManager));
        }

        public IEmployeeService EmployeeManager => _employeeSerivice.Value;

        public IEmployeeCardService EmployeeCardService => _employeeCardService.Value;
    }
}
