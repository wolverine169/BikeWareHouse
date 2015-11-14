using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeWareHouse.Domain.Reusable
{
    public class PopulateDate
    {
        public PopulateDate()
        {
        }

        public List<Int32> DaysOfMonth()
        {
            List<Int32> days = new List<Int32>();

            for (int i = 1; i < 32; i++)
            {
                days.Add(i);
            }

            return days;
        }

        public List<Int32> MonthsOfYear()
        {
            List<Int32> months = new List<Int32>();

            for (int i = 1; i < 13; i++)
            {
                months.Add(i);
            }

            return months;
        }

        public List<Int32> YearsOfAge()
        {
            List<Int32> years = new List<Int32>();

            DateTime today = DateTime.Today;

            Int32 year = today.Year;

            for (int i = 0; i < 110; i++)
            {

                years.Add(year - i);
            }

            return years;
        }

    }
}
