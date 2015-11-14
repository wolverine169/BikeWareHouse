using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeWareHouse.Domain
{
    [Serializable()]
    public abstract class AbstractPersistentObject
    {

        private int id;

        public AbstractPersistentObject()
        {
            this.id = -1;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public bool isPersistent()
        {
            return this.id != -1;
        }
    }

}