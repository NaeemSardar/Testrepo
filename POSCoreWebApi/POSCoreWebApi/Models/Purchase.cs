using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesEntities
{
	public class Purchase
	{
		[Key]
		public int Id { get; set; }
		public int PurchaseNo { get; set; }
		public string BillNo { get; set; }
		public int AccountMasterId { get; set; }
		public string ChildCode { get; set; }
		public decimal GrossBill { get; set; }
		public decimal GiveAmount { get; set; }
		public decimal ReceivedAmount { get; set; }
		public decimal Discount { get; set; }
		public decimal NetBill { get; set; }
		public int TaxId { get; set; }
		public decimal TotalTax { get; set; }
		public DateTime Date { get; set; }
		public string Status { get; set; }
		public int UserId { get; set; }
		public virtual AccountMaster AccountMaster { get; set; }
		[NotMapped]
		public Tax Tax { get; set; }
		public virtual IList<PurchaseDetail> PurchaseDetails { get; set; }
		[NotMapped]
		public IList<CurrencyDetail> CurrencyDetails { get; set; }
		[NotMapped]
		public IList<ChequeDetail> ChequeDetails { get; set; }
	}
}
