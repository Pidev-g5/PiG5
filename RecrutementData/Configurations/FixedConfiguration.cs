using RecrutementDomain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecrutementData.Configurations
{
    class FixedConfiguration : EntityTypeConfiguration<Fixed>
    {
        public FixedConfiguration()
        {
            ToTable("Fixed");
            HasKey(v => v.FixedId);

            HasRequired(c => c.reserved)
              .WithMany(cat1 => cat1.fixeds)
              .HasForeignKey(cc => cc.ReservedId)
              .WillCascadeOnDelete(true);




        }
    }
}
