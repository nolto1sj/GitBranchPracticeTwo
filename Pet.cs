using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBranchPracticeTwo
{
    internal abstract class Pet
    {
        public string Name { get; set; }
        public bool IsGecko { get; set; }
        public virtual void MakeHappyNoise()
        {
            Console.WriteLine("caw caw!");
        }
    }
}
