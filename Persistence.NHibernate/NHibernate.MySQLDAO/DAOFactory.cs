using System;
using BikeWareHouse.Domain;
using BikeWareHouse.Repositories;
using BikeWareHouse.Repositories.Reusable;

namespace Persistence.NHibernate.MySQLDAO
{

     public class DAOFactory : IRepositoryFactory
    {
        private UserDAO userDAO;
       
        private IMySession session;
        
        public DAOFactory()
        {
            this.userDAO = new UserDAO();
            this.session = new NHibernateSession();
            
        }

        public IUserRepository createUserRepository()
        {
            return this.userDAO;
        }
      
        public IMySession createSqlSession()
        {
            return this.session;
        }
    }
}
