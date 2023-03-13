using MediatR;
using webAPIMediatR.Models;

namespace webAPIMediatR.Data.Handlers
{
	public class GetSalesDataHandler : IRequestHandler<GetSalesDataQuery, List<SalesData>
	{
	}
}
