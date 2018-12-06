using System.Collections.Generic;
using StarWars.Pattern.Factory;
using StarWars.Classes.Solders;

namespace StarWars.Pattern.Singleton
{
    class Client
    {
        public List<AbstractSolder> SoldersList;
        public AbstractSolder CurrentSolder { get; set; }

        private Client()
        {
            SoldersList = new List<AbstractSolder>();
            AssaultFactory = new AssaultFartory();
            GunnerFactory = new GunnerFactory();
            ReconFactory = new ReconFactory();
            SniperFactory = new SniperFactory();
        }

        private static Client SingletonClient;

        public static Client GetInstance()
        {
            if (SingletonClient == null)
                SingletonClient = new Client();
            return SingletonClient;
        }

        private AbstractFactory AssaultFactory;
        private AbstractFactory GunnerFactory;
        private AbstractFactory ReconFactory;
        private AbstractFactory SniperFactory;

        public void CreateAssault()
        {
            SoldersList.Add(AssaultFactory.CreateSolder());
        }
        public void CreateGunner()
        {
            SoldersList.Add(GunnerFactory.CreateSolder());
        }
        public void CreateRecon()
        {
            SoldersList.Add(ReconFactory.CreateSolder());
        }
        public void CreateSniper()
        {
            SoldersList.Add(SniperFactory.CreateSolder());
        }
    }
}
