﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Mammal : Animals
    {
        public Mammal(string name) : base(name)
        {

        }

        public override void Greet()
        {
            Console.WriteLine("hello mom");
        }

        public override string WantChild()
        {
            return "want a child from my uterus";
        }
    }
}
