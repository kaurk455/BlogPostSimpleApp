﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPostSimpleApp.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
      public List<Post> Posts { get; set; }
    }
}
