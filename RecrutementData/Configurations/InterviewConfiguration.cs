using RecrutementDomain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecrutementData.Configurations
{
    class InterviewConfiguration : EntityTypeConfiguration<Interview>
    {
        public InterviewConfiguration()
        {
            ToTable("Interview");
            HasKey(v => v.InterviewId);

            HasRequired(c => c.person)
              .WithMany(cat1 => cat1.interviews)
              .HasForeignKey(cc => cc.PersonId)
              .WillCascadeOnDelete(true);


           

        }
    }
}
