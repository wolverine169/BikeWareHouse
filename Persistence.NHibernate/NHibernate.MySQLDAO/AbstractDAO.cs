
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using NHibernate;
using BikeWareHouse.Repositories.Reusable;
using BikeWareHouse.Domain;

namespace Persistence.NHibernate.MySQLDAO
{

    public class AbstractDAO<T> : IRepository<T> where T : AbstractPersistentObject
    {
        private Type type;
        private String typeName;

        public AbstractDAO()
        { }

        public AbstractDAO(Type type)
        {
            this.type = type;
            this.typeName = this.type.ToString();

        }

        public String getNameType()
        {
            String[] words = this.typeName.Split('.');
            String result = words[1];
            return result;
        }


        public void save(T t, IMySession s)
        {
            bool isPersistent = t.isPersistent();
            ISession session = this.getSQLSession(s);
            ITransaction transaction = session.BeginTransaction();
            try
            {

                if (!isPersistent)
                {
                    session.Save(t);
                }
                else
                {
                    session.SaveOrUpdate(t);
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new RepositoryException(ex);
            }
            finally
            {
                try
                {
                    if (s != null)
                    {
                        session.Close();
                    }
                }
                catch (Exception ex)
                {
                    throw new RepositoryException(ex);
                }
            }
        }

        public IList<T> findAll(IMySession s)
        {
            IList<T> list = null;
            ISession session = this.getSQLSession(s);
            ITransaction transaction = null;

            try
            {
                transaction = session.BeginTransaction();

                list = session.CreateCriteria(typeof(T)).List<T>();

                transaction.Commit();

            }
            catch (Exception ex)
            {
                //transaction.Rollback();  //no need to rollback a select
                throw new RepositoryException(ex);
            }
            finally
            {
                try
                {
                    if (s != null)
                    {
                        session.Close();
                    }
                }
                catch (Exception ex)
                {
                    throw new RepositoryException(ex);
                }
            }
            return list;
        }



        public T findById(int id, IMySession s)
        {
            throw new NotImplementedException();
        }

        public void delete(T t, IMySession s)
        {
            throw new NotImplementedException();
        }

        protected ISession getSQLSession(IMySession s)
        {
            if (!(s is NHibernateSession))
            {
                throw new RepositoryException("incompatible session object");
            }

            NHibernateSession session = (NHibernateSession)s;

            return session.getSession();
        }
    }
}

