using BikeWareHouse.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeWarehouse.Domain
{

    public class User : AbstractPersistentObject, IDataErrorInfo
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
            DateTime birthday = birthDate;
            Int32 age = now.Year - birthday.Year;
            if (now.Month < birthday.Month || (now.Month == birthday.Month && now.Day < birthday.Day))//not had bday this year yet
                age--;
            return age;
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

        public string Error
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string this[string columnName]
        {
            get
            {
                string result = null;

                if (columnName == "FirstName")
                {
                    if (string.IsNullOrEmpty(FirstName))
                        result = "Voornaam kan niet leeg zijn";
                }

                if (columnName == "Name")
                {
                    if (string.IsNullOrEmpty(Name))
                        result = "Naam kan niet leeg zijn";
                }

                if (columnName == "BirthDate")
                {
                    DateTime date = new DateTime(1925,1,1);
                    if (BirthDate < date || BirthDate > DateTime.Today )
                   result = "Gelieve een echte datum in te vullen";
                }

                if (columnName == "Weight")
                {
                    String gewicht = Weight.ToString();
                    decimal w1 = new Decimal();
                    if (Decimal.TryParse(gewicht, out w1) == false || Weight < 10)
                        result = "Gelieve een gewicht in te vullen in formaat *.*";
                }

                if (columnName == "Height")
                {
                    String hoogte = Height.ToString();
                    decimal h1 = new Decimal();
                    if (Decimal.TryParse(hoogte, out h1) == false || Height < 90)
                        result = "Gelieve een lengte in te vullen in formaat *.*";
                    }
                return result;
            }
        }
    }
}
