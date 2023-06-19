using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstantCredit.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICreditApplicationRepository CreditApplication { get; }
        void Save();
    }
}
