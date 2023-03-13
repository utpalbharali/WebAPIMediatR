using webAPIMediatR.Models;

namespace webAPIMediatR.Services
{
	public interface ISalesRepository
	{
		public Task<List<SalesData>> GetSalesDataAsync();
        public Task<SalesData> GetSalesDataByIdAsync(int Id);

        public Task<SalesData> AddSalesDataAsync(SalesData sales);
        public Task<int> UpdateSalesDataAsync(SalesData sales);
        public Task<int> DeleteSalesDataAsync(int Id);
    }
}
