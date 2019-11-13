using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Comments
    {
        
        public int Id { get; set; }

        [ForeignKey("PostId")]
        public Post Post { get; set; }

        public int ParentCommentId { get; set; }

        [Required]
        public DateTime DatePosted { get; set; }

        [ForeignKey("PostedBy")]
        public Person Person { get; set; }

        public List<Comments> Commentss { get; set; }
        
    }
}
