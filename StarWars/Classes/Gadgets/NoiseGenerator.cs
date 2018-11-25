using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Classes.Gadgets
{
    class NoiseGenerator : AbstractGadgets
    {
        public override string Message()
        {
            return "Генератор помех";
        }
    }
}
