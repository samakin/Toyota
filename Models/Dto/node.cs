﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Toyota.Models.Dto
{
    public class node
    {
        public string code { get; set; }
        public string name { get; set; }
        public string node_id { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
