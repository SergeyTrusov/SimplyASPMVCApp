using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TestTask.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(32)]
        public string Name { get; set; }
    }
}
