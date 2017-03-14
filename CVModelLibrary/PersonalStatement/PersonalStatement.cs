using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CVModelLibrary.PersonalStatement
{
    [Table("PersonalStatment")]
    public class PersonalStatement
    {

        public PersonalStatement()
        {
        }

        [Key]
        public int iD { get; set; }
        public string PStatment { get; set; }

    }


}
