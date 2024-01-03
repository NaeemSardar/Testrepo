using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesEntities
{
   public class PhoneNo
    {
        [Key]
        public int PhoneNoId { get; set; }
        public string PhoneNumber { get; set; }
        public int SaleManId { get; set; }
        public int AccountMasterId { get; set; }
        public virtual AccountMaster AccountMaster { get; set; }
        public virtual SalaryDetail SaleMan { get; set; }

    }
}
