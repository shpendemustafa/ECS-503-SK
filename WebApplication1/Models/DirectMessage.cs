using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class DirectMessage
    {
        public int Id { get; set; }

        public string FullName { get; set; }
        public DateTime TimeYouWrote { get; set; }
        
        [ForeignKey("Person")]
        public Person Persons { get; set; }
    }
}
