using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdInheritance
{
    abstract class Bird
    {
        public static Random Randomizer = new Random();
        public abstract Egg[] LayEggs(int numberOfEggs);
    }
}
