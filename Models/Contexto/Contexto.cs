using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Models.Contexto
{
    public class Contexto : DbContext
    {
        //Construtor
        public Contexto(DbContextOptions<Contexto> option) : base(option)
        {
            Database.EnsureCreated();
        }

        public DbSet<Usuario> Usuario { get; set; } 
    }
}
