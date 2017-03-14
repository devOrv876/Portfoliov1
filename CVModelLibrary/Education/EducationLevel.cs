using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CVModelLibrary.Education
{
    [Table("EducationLevel")]
    public class EducationLevel
    {
        public EducationLevel()
        {
            //Institutions = new HashSet<Institution>();
            //Qualifications = new HashSet<Qualification>();
        }

        [Key]
        public int eduLevel_ID { get; set; }
        public string eduLevel { get; set; }

    }
}
