using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesEntities
{
   public class SaleReturn
    {
		[Key]
		public int SaleReturnId { get; set; }
		public int SaleId { get; set; }
		public int ItemId { get; set; }
		public string LineItemId { get; set; }
		public int UnitId { get; set; }
		public decimal Qty { get; set; }
		public int SizeId { get; set; }
		public int DesignId { get; set; }
		public decimal Rate { get; set; }
		public decimal ItemPrice { get; set; }
		public int Discount { get; set; }
		public int WareHouseId { get; set; }
		public string Status { get; set; }
		public int ColourId { get; set; }
		public DateTime? ExpiryDate { get; set; }
		public bool StockStatus { get; set; }
		public DateTime Date { get; set; }
        public int UserId { get; set; }
		[NotMapped]
		public Item Item { get; set; }
        [NotMapped]
        public Unit Unit { get; set; }
        [NotMapped]
        public Size Size { get; set; }
        [NotMapped]
		public Design Design { get; set; }
		[NotMapped]
		public Colour Colour { get; set; }
	}
}
