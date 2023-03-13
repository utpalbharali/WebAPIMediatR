using MediatR.Models;
using Microsoft.EntityFrameworkCore;

namespace MediatR.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}

		public DbSet<SalesData> Sales { get; set; }
	}
}
