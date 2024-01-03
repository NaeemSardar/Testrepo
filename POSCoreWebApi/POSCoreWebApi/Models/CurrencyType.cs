using System;
using System.ComponentModel.DataAnnotations;

namespace BusinesEntities
{
    public class CurrencyType
    {
        [Key]
        public int CurrencyId { get; set; }

        public string Code { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }

    }
}
