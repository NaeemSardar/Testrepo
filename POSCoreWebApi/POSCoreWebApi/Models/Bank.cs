using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesEntities
{
   public class Bank
    {
        [Key]
        public int BankId { get; set; }
        public string BankName { get; set; }
        public Nullable<DateTime>  CreatedOn { get; set; }
    }
    
 
}
