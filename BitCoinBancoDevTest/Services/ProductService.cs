using BitCoinBancoDevTest.Interfaces;
using Domain;
using ServiceStack.Redis;
using ServiceStack.Redis.Generic;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BitCoinBancoDevTest.Services
{
	public class ProductService : IProduct
	{
		public Task<IList<Product>> GetProductAsync()
		{
			using (RedisClient client = new RedisClient("localhost", 6379))
			{
				IRedisTypedClient<Product> product = client.As<Product>();
				return Task.FromResult(product.GetAll());
			}
		}
		public void SetProductAsync(dynamic json)
		{
			for (int i = 0; i < json.Count-1; i++)
			{
				var currentItem = json[i];
			}
			using (RedisClient client = new RedisClient("localhost", 6379))
			{
				IRedisTypedClient<Product> product = client.As<Product>();
				//product.StoreAll(json);
			}
		}
	}
}
