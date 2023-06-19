using InstantCredit.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstantCredit.Data.Repository.IRepository
{
    public interface ICreditApplicationRepository : IRepository<CreditApplication>
    {
        void Update(CreditApplication obj);
    }
}
