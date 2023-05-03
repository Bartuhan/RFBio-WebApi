using Entities.Models;
using Repositories.Contrats;
using Services.Contrats;

namespace Services
{
    public class EmployeeManager : IEmployeeService
    {
        private IRepositoryManager _manager;

        public EmployeeManager(IRepositoryManager repositoryManager)
        {
            _manager = repositoryManager;
        }

        public Employee CreateService(Employee entity)
        {
            _manager.Employee.Create(entity);
            _manager.Save();
            return entity;
        }

        public void DeleteService(int id, bool trackChanges)
        {
            var entity = _manager.Employee.GetEmployeeByID(id,trackChanges);
            if (entity is null)
                throw new Exception($"Emplyee With ID :{id} Could Not Found . ");

            _manager.Employee.Delete(entity);
            _manager.Save();
        }

        public IEnumerable<Employee> GetAllService(bool trackChanges)
        {
            return _manager.Employee.GetAllEmployee(trackChanges);
        }

        public Employee GetByIDService(int id, bool trackChanges)
        {
            return _manager.Employee.GetEmployeeByID(id, trackChanges);
        }

        public void UpdateService(Employee employee, int id, bool trackChanges)
        {
            var entity = _manager.Employee.GetEmployeeByID(id, trackChanges);
            if (entity is null)
                throw new Exception($"Emplyee With ID :{id} Could Not Found . ");
            
            entity.DepartmentId = employee.DepartmentId;
            entity.CompanyId = employee.CompanyId;
            entity.EmployeeId = employee.EmployeeId;
            entity.EmployeeFirstName = employee.EmployeeFirstName;
            entity.EmployeeLastName = employee.EmployeeLastName;
            entity.EmployeeMiddleName = employee.EmployeeMiddleName;
            entity.EmployeeTypeId = employee.EmployeeTypeId;
            entity.EmployeeStaffId = employee.EmployeeStaffId;
            entity.EmployeePositionId = employee.EmployeePositionId;
            entity.EmployeeJobId = employee.EmployeeJobId;
            entity.EmployeeLocationId = employee.EmployeeLocationId;
            entity.NationalIdNumber = employee.NationalIdNumber;
            entity.ContactId = employee.ContactId;
            entity.BiometricId = employee.BiometricId;
            entity.BirthDate = employee.BirthDate;
            entity.MaritalStatusId = employee.MaritalStatusId;
            entity.GenderId = employee.GenderId;
            entity.HireDate = employee.HireDate;
            entity.TerminationDate = employee.TerminationDate;
            entity.SalariedFlag = employee.SalariedFlag;
            entity.Deleted  = employee.Deleted;
            entity.EmployeePhoto = employee.EmployeePhoto;
            entity.BeginDate = employee.BeginDate;
            entity.LeaveDate = employee.LeaveDate;
            entity.ParentId = employee.ParentId;
            entity.IsActive = employee.IsActive;
            entity.isTransfered =employee.isTransfered;
            

            _manager.Employee.Update(entity);
            _manager.Save();
        }
    }
}