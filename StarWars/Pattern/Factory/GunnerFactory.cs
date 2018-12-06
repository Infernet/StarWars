using System;
using StarWars.Classes.Gadgets;
using StarWars.Classes.Solders;
using StarWars.Classes.Weapons;


namespace StarWars.Pattern.Factory
{
    class GunnerFactory : AbstractFactory
    {
        public override AbstractSolder CreateSolder()
        {
            return new Gunner("Штурмовое подразделение", Random.Next(1, 1000), Ranks[Random.Next(0, Ranks.Count - 1)], new MachineGun(), new Grenade());
        }
    }
}
