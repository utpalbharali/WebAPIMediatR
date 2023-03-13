
using Microsoft.EntityFrameworkCore;
using webAPIMediatR.Models;

namespace webAPIMediatR.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}

		public DbSet<SalesData> Sales { get; set; }
	}
}
