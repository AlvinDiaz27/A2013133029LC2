﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2013133029_ENT.Entidades;

namespace _2013133029_PER.EntitiesConfigurations
{
    public class BaseDatosConfiguration : EntityTypeConfiguration<BaseDatos>
    {
        public BaseDatosConfiguration()
        {
            HasKey(a => a.BaseDatosId);
            HasMany(c => c.Cuentas)
                .WithRequired(c => c.BaseDatos);
        }
    }
}
