using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CVModelLibrary.WorkExperience
{
    [Table("Company")]
    public class Company
    {
        [Key]
        public int company_ID { get; set; }
        public string companyName { get; set; }
        public DateTime dateEmployed { get; set; }
        public string address { get; set; }

        public int? job_ID { get; set; }

        public virtual JobDescription jobdescriptions { get; set;
        }
    }
}
