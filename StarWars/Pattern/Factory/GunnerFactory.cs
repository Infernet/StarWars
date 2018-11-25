using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.Classes.Gadgets;
using StarWars.Classes.Solders;
using StarWars.Classes.Weapons;


namespace StarWars.Classes.Factory
{
    class GunnerFactory : AbstractFactory
    {
        public override AbstractSolder CreateSolder()
        {
            return new Gunner("Штурмовое подразделение", Random.Next(1, 1000), Ranks[Random.Next(0, Ranks.Count - 1)], new MachineGun(), new Grenade());
        }
    }
}
