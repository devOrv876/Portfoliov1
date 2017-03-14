using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CVModelLibrary.Education
{
    [Table("Qualification")]
    public class Qualification
    {

        public Qualification()
        {
        }
        [Key]
        public int qual_ID { get; set; }
        public string qualification { get; set; }
        public string module { get; set; }
        public string moduleDetail { get; set; }
        public string grade { get; set; }
        public int? eduLevel_ID { get; set; }
        public int? Inst_ID { get; set; }
        //Foriegn Keys           
        public virtual EducationLevel EducationLevels { get; set; }
        public virtual Institution Institutions { get; set; }


    }
}
