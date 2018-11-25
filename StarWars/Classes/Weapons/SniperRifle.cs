using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Classes.Weapons
{
    class SniperRifle : AbstractWeapon
    {
        public override string Message()
        {
            return "Снайперская винтовка";
        }
    }
}
