using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetFirstTake.Models
{
    public class AppDbContext : DbContext 
    {
		public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
		{

		}

		public DbSet<Necklace> Necklace { get; set; }
		public DbSet<Feedback> Feedbacks { get; set; }
	}
}
