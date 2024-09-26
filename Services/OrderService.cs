using ProvaPub.Models;
using ProvaPub.Repository;

namespace ProvaPub.Services
{
	public class OrderService
	{
        TestDbContext _ctx;

        public OrderService(TestDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Order> PayOrder(string paymentMethod, decimal paymentValue, int customerId)
		{
			if (paymentMethod == "pix")
			{
				//Faz pagamento...
			}
			else if (paymentMethod == "creditcard")
			{
				//Faz pagamento...
			}
			else if (paymentMethod == "paypal")
			{
				//Faz pagamento...
			}

			return await InsertOrder(new Order() //Retorna o pedido para o controller
            {
                Value = paymentValue
            });


		}

		public async Task<Order> InsertOrder(Order order)
        {
			//Insere pedido no banco de dados
			return (await _ctx.Orders.AddAsync(order)).Entity;
        }
	}
}
