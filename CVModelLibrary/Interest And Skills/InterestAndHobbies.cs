using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CVModelLibrary.InterestAndSkills
{
    [Table("InterestAndHobbies")]
    public class InterestAndHobbies
    {
        [Key]
        public int interest_ID { get; set; }
        public string interestDescription { get; set; }

        public ExperienceAndSkills MyProperty { get; set; }
    }
}
