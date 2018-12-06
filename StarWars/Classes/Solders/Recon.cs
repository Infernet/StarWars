using StarWars.Classes.Weapons;
using StarWars.Classes.Gadgets;
using System;

namespace StarWars.Classes.Solders
{
    class Recon:AbstractSolder
    {
        private string Eavesdropping;


        public Recon(string unitCode, int number, string rank, AbstractWeapon gun, AbstractGadgets gadgets)
    : base(unitCode + " №" + number.ToString(), rank, gun,gadgets)
        {
            Eavesdropping = "Скрытность";
        }

        public override string Message()
        {
            return base.Message()+ "Особенность - " + Eavesdropping + Environment.NewLine;
        }

        public override string WhatIsSpecialty()
        {
            return Eavesdropping;
        }
    }
}
