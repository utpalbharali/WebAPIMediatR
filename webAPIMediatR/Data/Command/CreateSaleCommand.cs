using MediatR;
using System.ComponentModel.DataAnnotations;
using webAPIMediatR.Models;

namespace webAPIMediatR.Data.Command
{
	public class CreateSaleCommand : IRequest<SalesData>
	{
        public CreateSaleCommand(int Id, DateTime dateTime, decimal amt)
        {
			Id = Id;
			Date = dateTime;
			Amount = amt;
		}

			public int Id { get; set; }
		public DateTime Date { get; set; }
		public Decimal Amount { get; set; }
    }
}
