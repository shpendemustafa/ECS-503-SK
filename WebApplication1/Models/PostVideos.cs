using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PostVideos
    {
        public int Id { get; set; }

        [ForeignKey("PostId")]
        public Post Post { get; set; }
        public string FileName { get; set; }
        public int FileSize { get; set; }
        public bool IsPrimary { get; set; }
    }
}
