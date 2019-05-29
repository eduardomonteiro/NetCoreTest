using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BitCoinBancoDevTest.Interfaces
{
	public interface IProduct
	{
		Task<IList<Product>> GetProductAsync();
		void SetProductAsync(dynamic json);
	}
}
