using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstantCredit.Service.LifeTimeExample
{
    public class ScopedService
    {
        private readonly Guid guid;
        public ScopedService()
        {
            guid = Guid.NewGuid();
        }

        public string GetGuid() => guid.ToString();
    }
}
