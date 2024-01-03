using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesEntities
{
    public class Voucher
    {
        [Key]
        public int VoucherId { get; set; }
        public int AccountMasterId { get; set; }
        public int HeadCode { get; set; }
        public string ParentCode { get; set; }
        public string ChildCode { get; set; }
        public string VoucheNo { get; set; }              
        public string AccountName { get; set; }
        public DateTime? Date { get; set; }
        public decimal Dr { get; set; }
        public decimal Cr { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int TransNo { get; set; }
        public string FormType { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }
        [NotMapped]
        public AccountMaster AccountMaster { get; set; }
        [NotMapped]
        public ChildAccount ChildAccount { get; set; }
    }
}
