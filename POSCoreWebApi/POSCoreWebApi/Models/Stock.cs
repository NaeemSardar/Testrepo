using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesEntities
{
    public class Stock
    {
		[Key]
		public int StockId { get; set; }
		public int PurchaseId { get; set; }
		public int ItemId { get; set; }
		public string LineItemId { get; set; }
		public int UnitId { get; set; }
		public decimal Qty { get; set; }
		public string Abrivation { get; set; }
		public int SizeId { get; set; }
		public int DesignId { get; set; }
		public decimal Rate { get; set; }
		public decimal ItemPrice { get; set; }
		public int Discount { get; set; }
		public int WareHouseId { get; set; }
		public string Status { get; set; }
		public int ColourId { get; set; }
		public DateTime ExpiryDate { get; set; }
		public bool StockStatus { get; set; }
		public int UserId { get; set; }
		public virtual Item Item { get; set; }
		public virtual Unit Unit { get; set; }
		public virtual Size Size { get; set; }
		public virtual Design Design { get; set; }
		public virtual Colour Colour { get; set; }
	}
}
