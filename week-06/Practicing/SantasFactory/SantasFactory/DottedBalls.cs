﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SantasFactory
{
    class DottedBalls : Toys
    {
        public string Color { get; set; }
        public int Size { get; set; }

        public DottedBalls(string type, string color) : base (type, 10)
        {
            Color = color;
            Type = type;
        }

    }
}
