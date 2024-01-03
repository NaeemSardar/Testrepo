using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesEntities
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string TagNo { get; set; }
        public string Description { get; set; } = "";
        public int CategoryId { get; set; } = 0;
        public int UnitId { get; set; } = 0;
        public int SizeId { get; set; } = 0;
        public int Box { get; set; } = 0;
        public double UnitQty { get; set; } = 0;
        public int QtyInBox { get; set; } = 0;
        public double PurchasePricePerItem { get; set; } = 0;
        public double PurchasePrice { get; set; } = 0;
        public int SalePricePerItem { get; set; } = 0;
        public double SalePrice { get; set; } = 0;
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime? ExpiryDate { get; set; } = null;
        public bool IsActive { get; set; } = true;
        public double AvailableQty { get; set; } = 0;
        public double MinQty { get; set; } = 0;
        public double Percent { get; set; } = 0;
        public double PercentRate { get; set; } = 0;
        [NotMapped]
        public Rate Rates { get; set; } = new Rate();
        [NotMapped]
        public Discount Discounts { get; set; } = new Discount();
        [NotMapped]
        public Category Category { get; set; } = new Category();
        [NotMapped]
        public Unit Unit { get; set; } = new Unit();
        [NotMapped]
        public Size Size { get; set; } = new Size();
        [NotMapped]
        public Design Design { get; set; } = new Design();
        [NotMapped]
        public Colour Colour { get; set; } = new Colour();
    }
}
