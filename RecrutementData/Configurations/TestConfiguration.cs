using RecrutementDomain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecrutementData.Configurations
{
    public class TestConfiguration : EntityTypeConfiguration<Test>
    {
        public TestConfiguration()
        {
            ToTable("Test");
            HasKey(v => v.TestId);

            




        }
    }
}
