using MediatR;
using webAPIMediatR.Models;

namespace webAPIMediatR.Data
{
	public class GetSalesDataQuery : IRequest<SalesData>
	{
	}
}
