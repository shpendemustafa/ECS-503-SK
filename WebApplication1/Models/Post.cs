using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Post
    {
        
        public int Id { get; set; }

        [ForeignKey("PersonId")]
        public Person Person { get; set; }

        
        public string PostContent { get; set; }
        
        public DateTime PostedDate { get; set; }

        [ForeignKey("PostVideos")]
        public PostVideos PostVideo { get; set; }
    }
}
