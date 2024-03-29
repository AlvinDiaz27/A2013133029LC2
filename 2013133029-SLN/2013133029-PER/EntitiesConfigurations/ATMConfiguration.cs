﻿using _2013133029_ENT;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013133029_PER.EntitiesConfigurations
{
    public class ATMConfiguration : EntityTypeConfiguration<ATM>
    {
        public ATMConfiguration()
        {
            HasKey(a => a.ATMId);
            HasRequired(c => c.RanuraDeposito)
                .WithRequiredPrincipal(c => c.ATM);
            HasRequired(c => c.Teclado)
                .WithRequiredPrincipal(c => c.ATM);
            HasRequired(c => c.DispensadorEfectivo)
                .WithRequiredPrincipal(c => c.ATM);
            HasRequired(c => c.Pantalla)
                .WithRequiredPrincipal(c => c.ATM);
            HasOptional(c => c.Retiro)
                .WithRequired(c => c.ATM);
        }
    }
}
