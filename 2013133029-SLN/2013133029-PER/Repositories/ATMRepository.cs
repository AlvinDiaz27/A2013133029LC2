using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013133029_PER.Repositories
{
    public class ATMRepository : Repository<ATM>, IATMRepository
    {
        private readonly _2013133029_SLNDbContext _Context;

        private ATMRepository()
        {

        }

        public ATMRepository(_2013133029_SLNDbContext context)
        {
            _Context = context;
        }
    }
}

