using System;
using StarWars.Classes.Gadgets;
using StarWars.Classes.Solders;
using StarWars.Classes.Weapons;

namespace StarWars.Pattern.Factory
{
    class SniperFactory : AbstractFactory
    {
        public override AbstractSolder CreateSolder()
        {
            return new Sniper("Снайперский корпус", Random.Next(1, 1000), Ranks[Random.Next(0, Ranks.Count - 1)], new SniperRifle(), new Jetpack());
        }
    }
}
