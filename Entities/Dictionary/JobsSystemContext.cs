namespace Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class JobsSystemContext : DbContext
    {
        public JobsSystemContext()
            : base("name=JobsSystemContext")
        {
        }

        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<DesiredJob> DesiredJobs { get; set; }
        public virtual DbSet<Employer> Employers { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<Field> Fields { get; set; }
        public virtual DbSet<JobApplied> JobApplieds { get; set; }
        public virtual DbSet<JobCategory> JobCategories { get; set; }
        public virtual DbSet<Knowledge> Knowledges { get; set; }
        public virtual DbSet<LevelDesired> LevelDesireds { get; set; }
        public virtual DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidate>()
                .Property(e => e.CandidateEmail)
                .IsFixedLength();

            modelBuilder.Entity<Candidate>()
                .Property(e => e.CandidatePhone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DesiredJob>()
                .Property(e => e.Salary)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employer>()
                .Property(e => e.EmployerEmail)
                .IsFixedLength();

            modelBuilder.Entity<Employer>()
                .Property(e => e.Phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employer>()
                .Property(e => e.Website)
                .IsFixedLength();
        }
    }
}
