namespace ProvaPub.Models
{
	public class ProductList
	{
		public List<Product> Products { get; set; }
		public int TotalCount { get; set; }
		public bool HasNext { get; set; }
	}
}
