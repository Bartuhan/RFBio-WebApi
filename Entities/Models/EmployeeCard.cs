using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class EmployeeCard
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public byte CardType { get; set; }
        public string CardIdRaw { get; set; }
        public bool CardIdReverse { get; set; }
        public string CardId4Byte { get; set; }
        public string CardId4ByteHex { get; set; }
        public string CardId4ByteReverse { get; set; }
        public string CardId4ByteReverseHex { get; set; }
        public string CardId7Byte { get; set; }
        public string CardId7ByteHex { get; set; }
        public string CardId7ByteReverse { get; set; }
        public string CardId7ByteReverseHex { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public DateTime DefineDate { get; set; }
        public int DefineUserId { get; set; }
        public bool Cancelled { get; set; }
        public DateTime CancelDate { get; set; }
        public int CancelUserId { get; set; }
        public string CancelReason { get; set; }
        public bool IsPrimary { get; set; }
        public string CardStatus { get; set; }
        public bool CardActive { get; set; }
        public bool CardNew { get; set; }
        public DateTime Update_Date { get; set; }

    }
}
