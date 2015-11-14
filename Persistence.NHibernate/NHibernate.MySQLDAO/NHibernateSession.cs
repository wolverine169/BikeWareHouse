using BikeWareHouse.Repositories.Reusable;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Reflection;


public class NHibernateSession : IMySession
{
    private ISession session;
    private ITransaction transaction;
    private static ISessionFactory factory;
    private static Configuration configuration;

    public NHibernateSession()
    {
        Assembly assembly = typeof(NHibernateSession).Assembly;
        configuration = new Configuration();
        configuration.Configure();
        configuration.AddAssembly(assembly);

        factory = configuration.BuildSessionFactory();
    }

    public ISession getSession()
    {
        this.session = factory.OpenSession();
        return this.session;
    }

    public void close()
    {
        transaction = session.BeginTransaction();
        transaction.Commit();
    }

}