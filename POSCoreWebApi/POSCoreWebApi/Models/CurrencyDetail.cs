using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesEntities
{
    public class CurrencyDetail
    {
        [Key]
        public int CurrencyDetailId { get; set; }
        public int CurrencyId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public decimal Net { get; set; }
        public decimal CurrencyRate { get; set; }
        public string Remarks { get; set; }
        public string PaymentType { get; set; }
        public string MasterType { get; set; }
        public int PurchaseNo { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
       
        public string Vno { get; set; }

    }


}
