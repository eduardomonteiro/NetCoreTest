using System.Collections.Generic;
using System.Threading.Tasks;
using BitCoinBancoDevTest.Interfaces;
using Domain;
using PopulateDataFromJson;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace BitCoinBancoDevTest.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CatalogController : ControllerBase
	{
		IProduct _productService;
		public CatalogController(IProduct productService)
		{
			_productService = productService;
		}

		// GET api/Catalog
		[AcceptVerbs("GET")]
		[EnableQuery()]
		public Task<IList<Product>> GetCatalog()
		{
			ReadJson test = new ReadJson();
			dynamic data = test.GetData(new System.Net.WebClient());

			_productService.SetProductAsync(data);

			var products = _productService.GetProductAsync();
			return products;
		}
	}
}
