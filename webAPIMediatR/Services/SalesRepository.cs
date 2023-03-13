using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.EntityFrameworkCore;
using webAPIMediatR.Data;
using webAPIMediatR.Models;

namespace webAPIMediatR.Services
{
	public class SalesRepository : ISalesRepository
	{
		private readonly DataContext _dbContext;
		
		public SalesRepository(DataContext dbContext)
		{
			_dbContext = dbContext;				
		}
		public async Task<SalesData> AddSalesDataAsync(SalesData sales)
		{
			var result = _dbContext.Sales.Add(sales);
			await _dbContext.SaveChangesAsync();
			return result.Entity;
		}

		public async Task<int> DeleteSalesDataAsync(int Id)
		{
			var filteredData = _dbContext.Sales.Where(x => x.Id == Id).FirstOrDefault();
			_dbContext.Sales.Remove(filteredData);
			return await _dbContext.SaveChangesAsync();
		}

		public async Task<List<SalesData>> GetSalesDataAsync()
		{
			var filteredData = await _dbContext.Sales.ToListAsync();
			return filteredData;
		}

		public async Task<SalesData> GetSalesDataByIdAsync(int Id)
		{
			var filteredData = await _dbContext.Sales.Where(x => x.Id == Id).FirstOrDefaultAsync();
			return filteredData;
		}

		

		public async Task<int> UpdateSalesDataAsync(SalesData sales)
		{
			_dbContext.Sales.Update(sales);
			return await _dbContext.SaveChangesAsync();
		}
	}
}
