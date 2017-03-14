using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CVModelLibrary.Education
{
    [Table("Institution")]
    public class Institution
    {

        public Institution()
        {
            //Qualifications = new HashSet<Qualification>();

        }

        [Key]
        public int inst_ID { get; set; }
        public string name { get; set; }
        public DateTime studyDate { get; set; }
        public string institutionAddress { get; set; }
        public int? EduLevel_ID { get; set; }


        //-----------
        public virtual EducationLevel EducationLevels { get; set; }

    }
}
