using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Validation.Interfaces;

namespace UI.Validation.Classes
{
    public class UserValidation : IUserValidation
    {
        public bool ValidateBirthDate(DateTime birthDate, out ICollection<string> validationErrors)
        {
            validationErrors = new List<string>();
            String nulltime = "01/01/0001";
            
            if (birthDate.ToShortDateString() == nulltime)
            
                validationErrors.Add("Datum moet ingevuld worden !!!");

            return validationErrors.Count == 0;

        }

        public bool ValidateFirstName(string firstName, out ICollection<string> validationErrors)
        {
            throw new NotImplementedException();
        }

        public bool ValidateHeight(decimal height, out ICollection<string> validationErrors)
        {
            throw new NotImplementedException();
        }

        public bool ValidateName(string name, out ICollection<string> validationErrors)
        {
            throw new NotImplementedException();
        }

        public bool ValidateWeight(decimal weight, out ICollection<string> validationErrors)
        {
            throw new NotImplementedException();
        }
    }
}
