using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesEntities
{
    public class ItemInfo
    {
        [Key]
        public int ItemInfoId { get; set; }
        public int CategoryId { get; set; }
        public int ItemId { get; set; }
        public int UnitId { get; set; }
        public int SizeId { get; set; }
        public int Box { get; set; }
        public double UnitQty { get; set; }
        public int QtyInBox { get; set; }
        public double PurchasePricePerItem { get; set; }
        public double PurchasePrice { get; set; }
        public int SalePricePerItem { get; set; }
        public double SalePrice { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool IsActive { get; set; }
        public virtual Category Category { get; set; }
        public virtual Item Item { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual Size Size { get; set; }
    }
}
