using BikeWarehouse.Domain;
using BikeWareHouse.Repositories.Reusable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeWareHouse.Repositories
{
    public interface IUserRepository : IRepository<User>
    {

        List<User> findByName(String name, IMySession s);
    }
}
