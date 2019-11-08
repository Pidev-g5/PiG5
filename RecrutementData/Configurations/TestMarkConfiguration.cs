using RecrutementDomain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecrutementData.Configurations
{
    public class TestMarkConfiguration : EntityTypeConfiguration<TestMark>
    {
        public TestMarkConfiguration()
        {
            ToTable("TestMark");
            HasKey(v => v.TestMarkId);

            HasRequired(a => a.t)
              .WithMany(cat1 => cat1.Marks)
              .HasForeignKey(cc => cc.testId)
              .WillCascadeOnDelete(true);
            HasRequired(d => d.c)
             .WithMany(cat2 => cat2.candidats)
             .HasForeignKey(cc => cc.CandidatId)
             .WillCascadeOnDelete(true);




        }
    }
}
