﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesEntities
{
   public class Unit
    {
        [Key]
        public int UnitId { get; set; }
        public string UnitName { get; set; }
    }
}
