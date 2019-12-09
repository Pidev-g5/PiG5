using RecrutementDomain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecrutementData.Configurations
{
    class ReservedConfiguration : EntityTypeConfiguration<Reserved>
    {
        public ReservedConfiguration()
        {
            ToTable("Reserved");
            HasKey(v => v.ReservedId);

            HasRequired(c => c.interview)
              .WithMany(cat1 => cat1.reserveds)
              .HasForeignKey(cc => cc.InterviewId)
              .WillCascadeOnDelete(true);



           



        }
    }
}
