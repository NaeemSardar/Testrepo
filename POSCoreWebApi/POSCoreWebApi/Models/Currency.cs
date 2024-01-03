using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesEntities
{
    public  class Currency
    {
        [Key]
        public int CurrencyId { get; set; }
        public string CurrencyName{ get; set; }
        public DateTime Createdon{ get; set; }
    }
}
