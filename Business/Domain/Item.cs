using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeWareHouse.Domain;

namespace BikeWarehouse.Domain
{

  


    public abstract class Item : AbstractPersistentObject
    {

        private String name;
        private String description;
        private Decimal price;
        private DateTime purchaseDate;
        private DateTime commissioningDate;
        private DateTime outOfServiceDate;
        private Decimal distanceItem;

        protected Item()
        {
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public Decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public DateTime PurchaseDate
        {
            get { return purchaseDate; }
            set { purchaseDate = value; }
        }

        public DateTime CommissioningDate
        {
            get { return commissioningDate; }
            set { commissioningDate = value; }
        }

        public DateTime OutOfServiceDate
        {
            get { return outOfServiceDate; }
            set { outOfServiceDate = value; }
        }

        public Decimal DistanceItem
        {
            get { return distanceItem; }
            set { distanceItem = value; }

        }

    }
}
