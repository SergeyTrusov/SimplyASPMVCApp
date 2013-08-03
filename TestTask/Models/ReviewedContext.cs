﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestTask.Models
{
    public class ReviewedContext : DbContext
    {
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ReviewedContext()
        {
            Configuration.ProxyCreationEnabled = false;
        }
    }
}