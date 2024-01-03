using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BusinesEntities
{
    public class CreditCard
    {
        [Key]
        public int CreditCardId { get; set; }
        public string CreditCardNo { get; set; }
        public double Amount { get; set; }
        public double DeductRate { get; set; }
        public Bank Bank { get; set; }
        public double AmountDeposit { get; set; }
        public BankAccountHolder BankAccountHolder { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string AccountCode { get; set; }
        public string VNo { get; set; }
        public string FormName { get; set; }
    }
}
