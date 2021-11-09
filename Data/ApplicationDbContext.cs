using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Portfolio_Krypto.Models;

namespace Portfolio_Krypto.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Portfolio_Krypto.Models.Token> Token { get; set; }
        //public DbSet<Portfolio_Krypto.Models.TokenExpanded> TokenExpanded { get; set; }
        public DbSet<Portfolio_Krypto.Models.TokenName> TokenName { get; set; }
    }
}
