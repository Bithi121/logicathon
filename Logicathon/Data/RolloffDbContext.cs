using Logicathon.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logicathon.Data
{
    public class RolloffDbContext : DbContext
    {
        public RolloffDbContext(DbContextOptions<RolloffDbContext> options) : base(options)
        {

        }
        public DbSet<Login> login { get; set; }

    }
}
