﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TestTask.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public bool IsAnonymous { get; set; }

        public int ReviewId { get; set; }
        public virtual Review Review { get; set; }
    }
}
