using StarWars.Classes.Gadgets;
using StarWars.Classes.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Classes.Solders
{
    class Gunner : AbstractSolder
    {
        private string Barrier;


        public Gunner(string unitCode, int number, string rank, AbstractWeapon gun,AbstractGadgets gadgets)
    : base(unitCode + " №" + number.ToString(), rank, gun,gadgets)
        {
            Barrier = "Энергетический барьер";
        }

        public override string Message()
        {
            return base.Message() + "Особенность - " + Barrier + Environment.NewLine;
        }

        public override string WhatIsSpecialty()
        {
            return Barrier;
        }
    }
}
