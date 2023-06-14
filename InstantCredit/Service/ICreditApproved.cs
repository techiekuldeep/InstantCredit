using InstantCredit.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstantCredit.Service
{
    public interface ICreditApproved
    {
        double GetCreditApproved(CreditApplication creditApplication);
    }
}
