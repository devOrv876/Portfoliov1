namespace Portfoliov1.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using CVModelLibrary;
    using CVModelLibrary.Education;
    using CVModelLibrary.PersonalStatement;
    using CVModelLibrary.InterestAndSkills;
    using CVModelLibrary.WorkExperience;


    public class CVDataModelContext : DbContext
    {
        // Your context has been configured to use a 'CVDataModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Portfoliov1.Models.CVDataModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CVDataModel' 
        // connection string in the application configuration file.
        public CVDataModelContext()
            : base("name=CVDataModel")
        {

        }

        

        public DbSet<PersonalStatement> personalStatements { get; set; }

        public DbSet<EducationLevel> educationLevels { get; set; }
        public DbSet<Qualification> qualifications { get; set; }
        public DbSet<Institution> institutions { get; set; }

        public DbSet<Company> companys { get; set; }
        public DbSet<JobDescription> JobDescriptions { get; set; }

        public DbSet<ExperienceAndSkills> experiences { get; set; }
        public DbSet<InterestAndHobbies> interestes { get; set; }

        public DbSet<CVReferences> CVReferences1 { get; set; }




        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}