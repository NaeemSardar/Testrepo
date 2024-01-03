using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesEntities
{
    public class BankAccountHolder
    {
        [Key]
        public int AccountHolderId { get; set; }
        
        //public int BankId { get; set; }

 
        public string AccountHolderNo { get; set; }
        public string AccountHolderName { get; set; }
        public Nullable<DateTime> CreatedOn { get; set; }
        public virtual Bank Bank { get; set; }
    }
}
