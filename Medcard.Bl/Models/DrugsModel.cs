﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medcard.Bl.Models
{
    [Serializable]
    public class DrugsModel
    {
        public Guid PetId { get; set; }
        public string Description { get; set; } = "Препараты:\n-\n-\n-\n-\n-";
    }
}
