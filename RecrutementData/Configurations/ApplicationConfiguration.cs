using RecrutementDomain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecrutementData.Configurations
{
    public class ApplicationConfiguration : EntityTypeConfiguration<Application>
    {
        public ApplicationConfiguration()
        {
            ToTable("Application");
            HasKey(v => v.AppId);






        }
    }
}
