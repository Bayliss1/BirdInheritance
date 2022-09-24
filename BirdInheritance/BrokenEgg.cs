using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdInheritance
{
    class BrokenEgg : Egg
    {
        public BrokenEgg(double size, string color): base(size, color)
        {
            Console.WriteLine("A bird laid a broken egg");
        }
    }
}
