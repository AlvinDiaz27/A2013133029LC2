﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013133029_PER.Repositories
{
    public class RanuraDepositoRepository : Repository<RanuraDeposito>, IRanuraDepositoRepository
    {
        private readonly _2013133029_SLNDbContext _Context;

        public RanuraDepositoRepository(_2013133029_SLNDbContext _Context)
        {
            // TODO: Complete member initialization
            this._Context = _Context;
        }

        private RanuraDepositoRepository()
        {

        }
    }
}

