using MediatR;
using webAPIMediatR.Models;

namespace webAPIMediatR.Data
{
	public class GetSalesDataById : IRequest<SalesData>
	{
        public int Id { get; set; }
    }
}
