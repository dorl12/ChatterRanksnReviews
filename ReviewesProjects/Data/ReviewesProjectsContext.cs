using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RankingPages.Models;

namespace ReviewesProjects.Data
{
    public class ReviewesProjectsContext : DbContext
    {
        public ReviewesProjectsContext (DbContextOptions<ReviewesProjectsContext> options)
            : base(options)
        {
        }

        public DbSet<RankingPages.Models.Review>? Review { get; set; }
    }
}
