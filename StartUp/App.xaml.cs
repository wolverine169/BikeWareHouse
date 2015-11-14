using BikeWareHouse.Repositories.Reusable;
using BikeWareHouse.Repositories;
using Persistence.NHibernate.MySQLDAO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using UI;

namespace StartUp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            DAOFactory daoFactory = new DAOFactory();
            Registry.setRepositoryFactory(daoFactory);
            MainWindow window = new MainWindow();
            window.Show();

        }
    }
}
