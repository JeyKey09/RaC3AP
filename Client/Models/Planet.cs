﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaC3AP.Models
{
    public class Planet(byte number)
    {
        public int Unlock { get; set; }
        public byte Number = number;
    }
}
