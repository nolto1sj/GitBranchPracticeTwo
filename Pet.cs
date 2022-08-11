﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBranchPracticeTwo
{
    internal abstract class Pet
    {
        public string Name { get; set; }

        public bool isGecko { get; set; }

        public string Description { get; set; }

        public virtual void MakeHappyNoise()
        {
            Console.WriteLine("caw caw!");
        }
    }
}
