using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesEntities
{
    public class Order
    {
        public Order()
        {
           // this.OrderDetailsForPrint();
        }
		[Key]
		public int OrderId { get; set; }
		public int BillNo { get; set; }
		public int AccountMasterId { get; set; }
		public string ChildCode { get; set; }
		public decimal TotalBill { get; set; }
		public decimal GiveAmount { get; set; }
		public decimal ReceivedAmount { get; set; }
		public decimal Discount { get; set; }
		public int TaxId { get; set; }
		public decimal TotalTax { get; set; }
		public DateTime Date { get; set; }
		public string Status { get; set; }
        public bool Flag { get; set; }
        public int UserId { get; set; }
        public virtual AccountMaster AccountMaster { get; set; }
        public virtual Tax Tax { get; set; }
    }
}
