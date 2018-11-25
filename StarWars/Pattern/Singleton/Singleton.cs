using StarWars.Classes;
using StarWars.Classes.Solders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Pattern.Singleton
{
    class Singleton
    {
        public Client Client { get; set; }
        public AbstractSolder CurrentSolder { get; set; }

        private static Singleton SingletonClient;

        private Singleton()
        {
            Client = new Client();
        }

        public static Singleton GetSingleton()
        {
            if (SingletonClient == null)
                SingletonClient = new Singleton();
            return SingletonClient;
        }
    }
}
