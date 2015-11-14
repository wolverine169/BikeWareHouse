using System;

namespace BikeWareHouse.Repositories.Reusable
{
    public class RepositoryException : Exception
    {

        public RepositoryException()
        {
        }

        public RepositoryException(Exception t)
        {

            t.GetBaseException();
        }

        public RepositoryException(String s)
        {
            s = base.Message;
        }
    }
}
