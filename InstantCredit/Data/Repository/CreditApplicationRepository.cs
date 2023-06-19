using InstantCredit.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstantCredit.Data.Repository.IRepository
{
    public class CreditApplicationRepository : Repository<CreditApplication>, ICreditApplicationRepository
    {
        private readonly ApplicationDbContext _db;

        public CreditApplicationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CreditApplication obj)
        {
            _db.CreditApplicationModel.Update(obj);
        }
    }
}
