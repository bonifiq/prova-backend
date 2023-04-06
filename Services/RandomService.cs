namespace ProvaPub.Services
{
	public class RandomService
	{
		int seed;
		public RandomService()
		{
			seed = Guid.NewGuid().GetHashCode();
		}
		public int GetRandom()
		{
			return new Random(seed).Next(100);
		}

	}
}
