using BikeWarehouse.Domain;
using BikeWareHouse.Repositories;
using BikeWareHouse.Repositories.Reusable;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BikeWareHouse.Tasks
{

    public class UserTask : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private User user;

        public UserTask()
        {
            this.user = new User();

        }

        public virtual User User { get; set; }


        private void OnPropertyChanged(String property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }


        }

        public List<User> Users()
        {
            IList<User> list = new List<User>();
            IMySession s = null;

            try
            {
                s = Registry.RepositoryFactory.createSqlSession();
                IUserRepository cr = Registry.RepositoryFactory.createUserRepository();
                list = cr.findAll(s);


            }
            catch (RepositoryException e)
            {
                e.ToString();
            }
            finally
            {
                try
                {
                    if (s != null)
                    {
                        s.close();
                    }
                }
                catch (Exception e2)
                {
                    e2.ToString();
                }
            }


            List<User> returnList = (List<User>)list;
           // base.PropertyChanged("lstUsers");
            return returnList;
        }


        public void save(User user)
        {
            this.user = user;
            IMySession s = null;
            IUserRepository ur = Registry.RepositoryFactory.createUserRepository();
           
            try
            {
                s = Registry.RepositoryFactory.createSqlSession();

                ur.save(this.user, s);

            }
            catch (RepositoryException e)
            {
                e.ToString();
            }


        }

    }
}
