using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesEntities
{
    public class Tax
    {
        [Key]
        public int TaxId { get; set; }
        public string TaxName { get; set; }
        public double Ratio { get; set; }
        public bool IsActive { get; set; }
        public string OnTable  { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
    }
}
