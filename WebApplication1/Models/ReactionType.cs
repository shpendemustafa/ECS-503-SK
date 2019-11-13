using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ReactionType
    {

        public int Id { get; set; }
        public string TypeName { get; set; }        
        public string IconURL { get; set; }
 
    }
}
