using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesEntities
{
    public class Rate
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ItemId { get; set; }
        public double Rate1 { get; set; }
        public double Rate2 { get; set; }
        public double Rate3 { get; set; }
    }
}
