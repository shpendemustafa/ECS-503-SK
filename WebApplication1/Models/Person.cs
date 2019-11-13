﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Person
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength (20)]
        public string Name { get; set; }

        [Required]
        [MaxLength (20)]
        public string LastName { get; set; }

        [MaxLength (20)]
        public string Address { get; set; }
        [MaxLength(50)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(255)]
        public string Password { get; set; }

        public List<FriendWith> FriendsWith { get; set; }
    }
}
