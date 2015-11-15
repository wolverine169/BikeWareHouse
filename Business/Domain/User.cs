using BikeWareHouse.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeWarehouse.Domain
{

    public class User : AbstractPersistentObject
    {

        private String firstName;
        private String name;
        public DateTime dateOfBirth;
        public Decimal weight;
        public Decimal height;
        private List<Bike> bikeList;

        // never change this value 2089800123, or the existing user codes will become inconsistent!!
        // Note that basing the user code (domain knowledge) to the id (not domain
        // knowledge) necessitates that the id's are preserved upon restoration of a backup.
        public static IntegerObfuscator NUMBER_OBFUSCATOR = new IntegerObfuscator(2012300898);

        public User()
        {
            bikeList = new List<Bike>();
        }


        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }

        }

        public Decimal Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Decimal Height
        {
            get { return height; }
            set { height = value; }
        }

        public DateTime BirthDate
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public Int32 Age
        {
            get { return CalculateAge(BirthDate); }
            set { value = CalculateAge(BirthDate); }
        }

        private Int32 CalculateAge(DateTime birthDate)
        {
            DateTime now = DateTime.Today;
            // DateTime birthday = Convert.ToDateTime(birthDate);
            DateTime birthday = birthDate;
            Int32 age1 = now.Year - birthday.Year;
            if (now.Month < birthday.Month || (now.Month == birthday.Month && now.Day < birthday.Day))//not had bday this year yet
                age1--;
            return age1;
        }

        public List<Bike> GetBikeList
        {
            get { return bikeList; }
        }

        /**
       *
       * @return the code of this customer (10-digit string or empty if not
       * persistent)
       */
        public String GetCode
        {
            get
            {
                String result = null;
                if (this.isPersistent())
                {
                    int number = NUMBER_OBFUSCATOR.getObfuscated(this.Id);
                    result = String.Format(String.Format("{0,10}", number));
                }
                else
                {
                    result = "";
                }
                return result;
            }
        }

    }
}
