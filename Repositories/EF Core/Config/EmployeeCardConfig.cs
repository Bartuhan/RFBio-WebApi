using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EF_Core.Config
{
    public class EmployeeCardConfig : IEntityTypeConfiguration<EmployeeCard>
    {
        public void Configure(EntityTypeBuilder<EmployeeCard> builder)
        {
            builder.HasData(
                    new EmployeeCard {
                        Id = 1,
                        EmployeeId = 1,
                        CardType = 1,
                        CardIdRaw = "ASD",
                        CardIdReverse = true,
                        CardId4Byte = "ASD",
                        CardId4ByteHex = "ASD",
                        CardId4ByteReverse = "ASD",
                        CardId4ByteReverseHex = "ASD",
                        CardId7Byte = "ASD",
                        CardId7ByteHex = "ASD",
                        CardId7ByteReverse = "ASD",
                        CardId7ByteReverseHex = "ASD",
                        StartDate = Convert.ToDateTime("30.12.2007"),
                        FinishDate = Convert.ToDateTime("30.12.2007"),
                        DefineDate = Convert.ToDateTime("30.12.2007"),
                        DefineUserId = 1,
                        Cancelled = false,
                        CancelDate = Convert.ToDateTime("30.12.2007"),
                        CancelUserId = 1,
                        CancelReason = "ASD",
                        IsPrimary = true,
                        CardStatus = "ASD",
                        CardActive = true,
                        CardNew = true,
                        Update_Date = Convert.ToDateTime("30.12.2007"),
                    }
                );
        }
    }
}
