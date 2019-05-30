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
		public void SetProductAsync(List<Product> json)
		{
			using (RedisClient client = new RedisClient("localhost", 6379))
			{
				IRedisTypedClient<Product> product = client.As<Product>();
				//product.StoreAll(json);
			}
		}
	}
}
