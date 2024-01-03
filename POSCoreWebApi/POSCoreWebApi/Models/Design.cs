using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesEntities
{
    public class Design
    {
        [Key]
        public int DesignId { get; set; }
        public string DesignName { get; set; }

    }
}
