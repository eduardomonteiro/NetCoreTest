using BitCoinBancoDevTest.Interfaces;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace BitCoinBancoDevTest
{
	public class Program
	{
		IProduct _productService;

		public Program(IProduct productService)
		{
			_productService = productService;
			_productService.LoadJsonData();
		}
		public static void Main(string[] args)
		{
			CreateWebHostBuilder(args).Build().Run();
		}

		public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>();
	}
}
