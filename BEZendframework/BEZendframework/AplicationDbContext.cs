using Microsoft.EntityFrameworkCore;
using BEZendframework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BEZendframework
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Persona> DBPersona { get; set; }
    }
}
