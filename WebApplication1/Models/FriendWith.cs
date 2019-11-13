using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class FriendWith
    {
        public int Id { get; set; }
        public int FirstPerson { get; set; }
        public int SecondPersond { get; set; }
        public DateTime Friendaversary { get; set; }

    }
}
