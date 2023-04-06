namespace ProvaPub.Models
{
	public class CustomerList
	{
		public List<Customer> Customers { get; set; }
		public int TotalCount { get; set; }
		public bool HasNext { get; set; }
	}
}
