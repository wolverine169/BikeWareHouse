using BikeWareHouse.Repositories.Reusable;

namespace BikeWareHouse.Repositories
{
    public interface IRepositoryFactory
    {
        
        IUserRepository createUserRepository();
        IMySession createSqlSession();
     
    }
}
