using BikeWarehouse.Domain;
using BikeWareHouse.Repositories;
using BikeWareHouse.Repositories.Reusable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.NHibernate.MySQLDAO
{
    public class UserDAO : AbstractDAO<User>, IUserRepository
    {

        public List<User> findByName(string name, IMySession s)
        {
            throw new NotImplementedException();

            //not needed for the moment;
        }
    }
}
