using InstantCredit.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstantCredit.Service
{
    public class CreditValidationChecker : IValidationChecker
    {
        public string ErrorMessage => "You did not meet Age/Salary/Credit requiurements.";

        public bool ValidatorLogic(CreditApplication model)
        {
            if (DateTime.Now.AddYears(-18) < model.DOB)
            {
                return false;
            }
            if (model.Salary < 10000)
            {
                return false;
            }
            return true;
        }
    }
}
