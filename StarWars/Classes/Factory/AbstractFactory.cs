using StarWars.Classes.Solders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWars.Classes.Factory
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
                string[] ranks = File.ReadAllLines(Application.StartupPath + @"\Resources\Ranks.txt");
                foreach (string item in ranks)
                {
                    Ranks.Add(item);
                }
            }


        }
    }
}
