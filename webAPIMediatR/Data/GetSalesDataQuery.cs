using MediatR;
using webAPIMediatR.Models;
using webAPIMediatR.Services;

namespace webAPIMediatR.Data
{
	public class GetSalesDataQuery : IRequest<SalesData>
	{
		int a = 5;
		SalesRepository obj = new SalesRepository(5);
		
	}
}
