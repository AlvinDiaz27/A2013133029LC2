
using _2013133029_ENT.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013133029_PER.EntitiesConfigurations
{
    public class TecladoConfiguration : EntityTypeConfiguration<Teclado>
    {
        public TecladoConfiguration()
        {
            HasKey(a => a.TecladoId);
            Property(v => v.NumeroCuenta)
                .IsRequired();
            Property(v => v.Pin)
                .IsRequired();

        }
    }
}

