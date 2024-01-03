using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesEntities
{
	public class Sale
	{
		[Key]
		public int SaleNo { get; set; }
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
		public int UserId { get; set; }
	}
}
