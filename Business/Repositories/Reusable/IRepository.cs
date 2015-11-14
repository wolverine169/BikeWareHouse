using System.Collections.Generic;


namespace BikeWareHouse.Repositories.Reusable
{
    public interface IRepository<T>
    {
        void save(T t, IMySession s);
        IList<T> findAll(IMySession s);
        T findById(int id, IMySession s);
        void delete(T t, IMySession s);

    }
}
