using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesEntities
{
   public class ChequeDetail
    {
        [Key]
        public int ChequeDetailId { get; set; }
        public decimal Net { get; set; }

       // public decimal CurrencyRate { get; set; }

        public decimal Amount { get; set; }
        public string ChequeNumber { get; set; }
        public DateTime ChequeDate { get; set; }
        public string PaymentType { get; set; }
        public int BankId { get; set; }
        public int BankAccountHolderId { get; set; }

        //BankName:string;        
        public string AccountNo { get; set; }
        public string MasterType { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public virtual Purchase Purchase { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public string Vno { get; set; }
        public virtual Bank Bank { get; set; }
        public virtual BankAccountHolder BankAccountHolder { get; set; }
        public string FormName { get; set; }
    }
}
