﻿using StarWars.Classes.Solders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace StarWars.Pattern.Factory
{
    abstract class AbstractFactory
    {
        public abstract AbstractSolder CreateSolder();

        protected static Random Random = new Random();
        protected static List<string> Ranks;

        public AbstractFactory()
        {
            if (Ranks == null)
            {
                Ranks = new List<string>();
                string[] ranks = File.ReadAllLines(Application.StartupPath + @"\Resources\Text\Ranks.txt");
                foreach (string item in ranks)
                {
                    Ranks.Add(item);
                }
            }
        }
    }
}
