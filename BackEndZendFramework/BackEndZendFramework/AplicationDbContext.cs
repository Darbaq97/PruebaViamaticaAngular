using BackEndZendFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndZendFramework
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Persona> DBPersona { get; set; }
        public DbSet<Sector> Sector{ get; set; }
        public DbSet<Zona> Zona{ get; set; }
    }
}
