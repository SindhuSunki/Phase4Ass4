﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment4.Model;

namespace Assignment4.Data
{
    public class Assignment4DbContext : DbContext
    {
        public Assignment4DbContext (DbContextOptions<Assignment4DbContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment4.Model.Movie> Movie { get; set; } = default!;
    }
}
