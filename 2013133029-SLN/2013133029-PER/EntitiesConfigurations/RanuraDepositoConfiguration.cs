﻿using _2013133029_ENT.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013133029_PER.EntitiesConfigurations
{
    public class RanuraDepositoConfiguration : EntityTypeConfiguration<RanuraDeposito>
    {
        public RanuraDepositoConfiguration()
        {
            HasKey(a => a.RanuraDepositoId);
            Property(v => v.deposito)
                .IsRequired();
        }
    }
}
