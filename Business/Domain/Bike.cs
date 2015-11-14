namespace BikeWarehouse.Domain
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Bike : Item
    {
        private BikeType bikeType;
        //private User user;
        private List<Part> partList;

        public Bike(BikeType bikeType)
        {
            this.bikeType = bikeType;
            this.partList = new List<Part>();
        }

        public BikeType BikeType
        {
            get { return bikeType; }
            set { bikeType = value; }
        }

        // public User User
        //{
        //   get { return user; }
        //  set { user = value; }
        //}

        public List<Part> GetPartList
        {
            get { return partList; }
        }


    }
}

