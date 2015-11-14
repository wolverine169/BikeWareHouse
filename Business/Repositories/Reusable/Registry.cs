using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeWareHouse.Repositories.Reusable
{

    public class Registry
    {
        private static Registry instance;

        private static IRepositoryFactory repositoryFactory;

        private Registry()
        {
            repositoryFactory = null;
        }

        public static Registry Instance
        {
            get
            {
                if (Registry.instance == null)
                {
                    Registry.instance = new Registry();
                }
                return Registry.instance;
            }
        }

        public static IRepositoryFactory RepositoryFactory
        {
            get { return repositoryFactory; }

        }

        public static void setRepositoryFactory(IRepositoryFactory DAOFactory)
        {
            repositoryFactory = DAOFactory;
        }
    }

}