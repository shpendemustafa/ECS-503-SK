using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Reaction
    {
        
        public int Id { get; set; }

        [ForeignKey("PostId")]
        public int PostId { get; set; }

        [ForeignKey("CommentId")]
        public int CommentId { get; set; }

        [ForeignKey("ImageId")]
        public int ImageId { get; set; }
        public DateTime ReactionDate { get; set; }

        [ForeignKey("ReactionTypes")]
        public ReactionType ReactionType { get; set; }

        

    }
}
