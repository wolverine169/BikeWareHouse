using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Validation.Interfaces
{
    public interface IUserValidation 
    {

        bool ValidateFirstName(string firstName, out ICollection<string> validationErrors);
        bool ValidateName(string name, out ICollection<string> validationErrors);
        bool ValidateBirthDate(DateTime birthDate, out ICollection<string> validationErrors);
        bool ValidateWeight(Decimal weight, out ICollection<string> validationErrors);
        bool ValidateHeight(Decimal height, out ICollection<string> validationErrors);
    }
}
