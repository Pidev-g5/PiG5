using RecrutementDomain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecrutementData.Configurations
{
    public class QuestionConfiguration : EntityTypeConfiguration<Question>
    {
        public QuestionConfiguration()
        {
            ToTable("Question");
            HasKey(v => v.QstId);

            HasRequired(c => c.test)
              .WithMany(cat1 => cat1.questions)
              .HasForeignKey(cc => cc.TestId)
              .WillCascadeOnDelete(true);

           


        }
    }
}
