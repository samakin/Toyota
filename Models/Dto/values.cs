﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Toyota.Models.Dto
{
    public class values
    {
        public string Id { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
