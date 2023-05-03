using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CardType = table.Column<byte>(type: "tinyint", nullable: false),
                    CardIdRaw = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardIdReverse = table.Column<bool>(type: "bit", nullable: false),
                    CardId4Byte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardId4ByteHex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardId4ByteReverse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardId4ByteReverseHex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardId7Byte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardId7ByteHex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardId7ByteReverse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardId7ByteReverseHex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DefineDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DefineUserId = table.Column<int>(type: "int", nullable: false),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    CancelDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CancelUserId = table.Column<int>(type: "int", nullable: false),
                    CancelReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false),
                    CardStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardActive = table.Column<bool>(type: "bit", nullable: false),
                    CardNew = table.Column<bool>(type: "bit", nullable: false),
                    Update_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    EmployeeFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeMiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeTypeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeStaffId = table.Column<int>(type: "int", nullable: false),
                    EmployeePositionId = table.Column<int>(type: "int", nullable: false),
                    EmployeeJobId = table.Column<int>(type: "int", nullable: false),
                    EmployeeLocationId = table.Column<int>(type: "int", nullable: false),
                    NationalIdNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BiometricId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaritalStatusId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenderId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TerminationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SalariedFlag = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    EmployeePhoto = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    isTransfered = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "EmployeeCards",
                columns: new[] { "Id", "CancelDate", "CancelReason", "CancelUserId", "Cancelled", "CardActive", "CardId4Byte", "CardId4ByteHex", "CardId4ByteReverse", "CardId4ByteReverseHex", "CardId7Byte", "CardId7ByteHex", "CardId7ByteReverse", "CardId7ByteReverseHex", "CardIdRaw", "CardIdReverse", "CardNew", "CardStatus", "CardType", "DefineDate", "DefineUserId", "EmployeeId", "FinishDate", "IsPrimary", "StartDate", "Update_Date" },
                values: new object[] { 1, new DateTime(2007, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASD", 1, false, true, "ASD", "ASD", "ASD", "ASD", "ASD", "ASD", "ASD", "ASD", "ASD", true, true, "ASD", (byte)1, new DateTime(2007, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2007, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2007, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "BeginDate", "BiometricId", "BirthDate", "CompanyId", "ContactId", "Deleted", "DepartmentId", "EmployeeFirstName", "EmployeeJobId", "EmployeeLastName", "EmployeeLocationId", "EmployeeMiddleName", "EmployeePhoto", "EmployeePositionId", "EmployeeStaffId", "EmployeeTypeId", "GenderId", "HireDate", "IsActive", "LeaveDate", "MaritalStatusId", "NationalIdNumber", "ParentId", "SalariedFlag", "TerminationDate", "isTransfered" },
                values: new object[] { 1, new DateTime(2007, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASD", new DateTime(2007, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "ASD", false, 1, "ASD", 1, "ASD", 1, "ASD", new byte[] { 65, 83, 68 }, 1, 1, 1, "ASD", new DateTime(2007, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2007, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASD", "ASD", 1, true, new DateTime(2007, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeCards");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
