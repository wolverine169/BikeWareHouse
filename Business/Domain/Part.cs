namespace BikeWarehouse.Domain
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;



    public class Part : Item
    {

        private Bike bike;
        private BikeType bikeType;

        public Part()
        {
            bikeType = new BikeType();
            this.bike = new Bike(bikeType);
        }

        public Bike Bike
        {
            get { return bike; }
            set { bike = value; }
        }


    }
}
