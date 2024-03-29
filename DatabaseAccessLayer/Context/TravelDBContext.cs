﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DatabaseAccessLayer
{
    public class TravelDBContext:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<ApplicationForm> ApplicationForms { get; set; }
        public DbSet<Dice> Dices { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}
