using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CVModelLibrary;
using CVModelLibrary.Education;
using CVModelLibrary.PersonalStatement;
using CVModelLibrary.InterestAndSkills;
using CVModelLibrary.WorkExperience;

namespace Portfoliov1.Models
{
    public class CvViewModel
    {
        public List<PersonalStatement> personalStatements { get; set; }

        public List<EducationLevel> educationLevels { get; set; }

        public List<Qualification> qualifications { get; set; }

        public List<Institution> institutions { get; set; }

        public List<Company> companys { get; set; }
        public List<JobDescription> JobDescriptions { get; set; }

        public List<ExperienceAndSkills> experiences { get; set; }
        public List<InterestAndHobbies> interestes { get; set; }
    
        public List<CVReferences> CVReferences1 { get; set; }


    }
}