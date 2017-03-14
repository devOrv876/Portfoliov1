using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CVModelLibrary.WorkExperience

{
    [Table("JobDescription")]
    public class JobDescription

    {
        [Key]
        public int job_ID { get; set; }
        public string jobTitle { get; set; }
        public string duties { get; set; }

    }
}
