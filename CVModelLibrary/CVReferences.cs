using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CVModelLibrary
{

    [Table("CVReferences")]
    public class CVReferences
    {
        [Key]
        public int ref_id { get; set; }
        public string name { get; set; }
        public string company { get; set; }
        public string address { get; set; }
        public int phonenumber { get; set; }

    }
}
