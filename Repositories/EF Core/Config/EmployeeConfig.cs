using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EF_Core.Config
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                    new Employee {
                        CompanyId = 1,
                        DepartmentId = 1 ,
                        EmployeeId = 1 ,
                        EmployeeFirstName = "ASD",
                        EmployeeMiddleName = "ASD",
                        EmployeeLastName = "ASD",
                        EmployeeTypeId = 1,
                        EmployeeStaffId = 1,
                        EmployeePositionId = 1,
                        EmployeeJobId = 1,
                        EmployeeLocationId =1,
                        NationalIdNumber = "ASD",
                        ContactId = "ASD",
                        BiometricId = "ASD",
                        BirthDate = Convert.ToDateTime("30.12.2007"),
                        MaritalStatusId = "ASD",
                        GenderId = "ASD",
                        HireDate = Convert.ToDateTime("30.12.2007"),
                        TerminationDate = Convert.ToDateTime("30.12.2007"),
                        SalariedFlag = true,
                        Deleted = false,
                        EmployeePhoto = Encoding.ASCII.GetBytes("ASD"),
                        BeginDate = Convert.ToDateTime("30.12.2007"),
                        LeaveDate = Convert.ToDateTime("30.12.2007"),
                        ParentId = 1,
                        IsActive = 1,
                        isTransfered = false
                    } // Veri Tabanı İçin Base Datalar
                );
        }
    }
}
