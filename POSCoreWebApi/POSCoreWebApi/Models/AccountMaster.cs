using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesEntities
{
    public class AccountMaster
    {
        [Key]
        public int AccountMasterId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Reference { get; set; }
        public string ChildCode { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public decimal Balance { get; set; }
        public string Type { get; set; }
        public string CNIC { get; set; }
        public string Territory { get; set; }
        public virtual IList<PhoneNo> PhoneNos { get; set; }

    }

}
