﻿using BitCoinBancoDevTest.Interfaces;
using BitCoinBancoDevTest.Services;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BitCoinBancoDevTest
{
	public class Startup
	{
		public IConfiguration Configuration { get; }
		static IProduct _productService { get; }

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{

			//my services registration
			services.AddTransient<IProduct, ProductService>();	

			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

			//enable OData
			services.AddOData();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseMvc(routeBuilder =>
			{
				routeBuilder.EnableDependencyInjection();
				routeBuilder.Expand().Select().Count().OrderBy().Filter();
			});
		}
	}
}
