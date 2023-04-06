namespace ProvaPub.Models
{
	public class Order
	{
		public int Id { get; set; }
		public decimal Value { get; set; }
		public int CustomerId { get; set; }
		public DateTime OrderDate { get; set; }
		public Customer Customer { get; set; }
	}
}
