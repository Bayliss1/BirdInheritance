using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdInheritance
{
    class Ostrich : Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];
            for (int i = 0; i < numberOfEggs; i++)
            {
                eggs[i] = new Egg(Bird.Randomizer.NextDouble() + 12, "speckled");
            }
            return eggs;
        }
    }
}
