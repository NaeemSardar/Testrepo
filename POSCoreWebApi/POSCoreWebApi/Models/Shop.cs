using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesEntities
{
    public class Shop
    {
        [Key]
        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public DateTime Createdon { get; set; }
        public string Address { get; set; }
        public string ReportsLogo { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
    }
}
