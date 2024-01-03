using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesEntities
{
   public class AccountType
    {
        [Key]
        public int AccountTypeId { get; set; }
        public int HeadCode { get; set; }
        public string  Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }
        [NotMapped]
        public HeadAccount HeadCodes { get; set; }
    }
}
