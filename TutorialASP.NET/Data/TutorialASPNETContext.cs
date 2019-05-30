using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TutorialASP.NET.Models
{
    public class TutorialASPNETContext : DbContext
    {
        public TutorialASPNETContext (DbContextOptions<TutorialASPNETContext> options)
            : base(options)
        {
        }

        public DbSet<TutorialASP.NET.Models.Movie> Movie { get; set; }
    }
}
