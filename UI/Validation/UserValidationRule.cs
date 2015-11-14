using BikeWarehouse.Domain;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;


namespace BikeWareHouse.Validation
{
    public class UserValidationRule : ValidationRule
    {


        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            BindingGroup bindingGroup = (BindingGroup)value;

            // This user has the original values.
            User user = (User)bindingGroup.Items[0];

            // Check the new values.

            String firstName = (string)bindingGroup.GetValue(user, "FirstName");
            String name = (string)bindingGroup.GetValue(user, "Name");

            return null;
        }
    }
}
