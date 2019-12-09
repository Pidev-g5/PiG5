using RecrutementData.Conventions;
using RecrutementDomain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecrutementData.Configurations;

namespace RecrutementData
{
    public class Context: IdentityDbContext<User, CustomRole, int, CustomUserLogin, CustomUserRole, CustomUserClaim>
    {
        public Context():base("name=hr")
        {

        }
        
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Candidat> Candidates { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Discussion> Discussions { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Interview> Iterviews { get; set; }
        public DbSet<Reserved> Reserveds { get; set; }
        public DbSet<Fixed> Fixeds { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<TestMark> TestMarks { get; set; }
        public DbSet<Person> persons { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //convention et configuration
            //strategie d'heritage TPT...
            modelBuilder.Conventions.Add(new DateTimeConvention());
            modelBuilder.Entity<CustomUserRole>().HasKey(t => t.UserId);
            modelBuilder.Configurations.Add(new QuestionConfiguration());
            modelBuilder.Configurations.Add(new PersonConfiguration());
            modelBuilder.Configurations.Add(new InterviewConfiguration());
            modelBuilder.Configurations.Add(new ReservedConfiguration());
            modelBuilder.Configurations.Add(new FixedConfiguration());
            modelBuilder.Configurations.Add(new TestConfiguration());
            modelBuilder.Configurations.Add(new TestMarkConfiguration());
            modelBuilder.Configurations.Add(new ApplicationConfiguration());
            //  modelBuilder.Entity<CustomUserLogin>().HasKey(t => t.UserId);

        }
        public static Context Create()
        {
            return new Context();
        }
        static Context()
        {
            Database.SetInitializer<Context>(null);
        }

    }
}
