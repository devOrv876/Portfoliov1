using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CVModelLibrary.InterestAndSkills
{
    [Table("ExperienceAndSkills")]
    public class ExperienceAndSkills
    {
        [Key]
        public int exp_ID { get; set; }
        public string exp { get; set; }

    }
}
