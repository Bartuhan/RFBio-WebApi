using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public int CompanyId { get; set; }
        public int DepartmentId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeMiddleName { get; set; }
        public string EmployeeLastName { get; set; }
        public int EmployeeTypeId { get; set; }
        public int EmployeeStaffId { get; set; }
        public int EmployeePositionId { get; set; }
        public int EmployeeJobId { get; set; }
        public int EmployeeLocationId { get; set; }
        public string NationalIdNumber { get; set; }
        public string ContactId { get; set; }
        public string BiometricId { get; set; }
        public DateTime BirthDate { get; set; }
        public string MaritalStatusId { get; set; }
        public string GenderId { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime TerminationDate { get; set; }
        public bool SalariedFlag { get; set; }
        public bool Deleted { get; set; }
        public byte[] EmployeePhoto { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime LeaveDate { get; set; }
        public int ParentId { get; set; }
        public int IsActive { get; set; }
        public bool isTransfered { get; set; }
    }
}
