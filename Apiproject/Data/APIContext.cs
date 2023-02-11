using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apiproject.Entities;
using Microsoft.EntityFrameworkCore;

namespace Apiproject.Data
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Appuser> Users {get;set;}
        public DbSet<location> Location {get;set;}
    


    
    }

}