using StarWars.Classes.Weapons;
using StarWars.Classes.Gadgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Classes.Solders
{
    class Assault: AbstractSolder
    {
        private string Rage;

        public Assault(string unitCode, int number, string rank,AbstractWeapon gun, AbstractGadgets gadgets)
            :base(unitCode + " №" + number.ToString(), rank,gun,gadgets)
        {
            Rage = "Ярость";
        }

        public override string Message()
        {
            return base.Message()+ "Особенность - " + Rage + Environment.NewLine;
                
        }

        public override string WhatIsSpecialty()
        {
            return Rage;
        }
    }
}
