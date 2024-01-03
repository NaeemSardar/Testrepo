using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesEntities
{
   public class SalaryDetail
    {
        [Key]
        public int SalaryDetailId { get; set; }
        public int AccountMasterId { get; set; }
        public decimal Salary { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public virtual AccountMaster AccountMaster { get; set; }

    }
}
