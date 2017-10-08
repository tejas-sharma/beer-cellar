using System.IO;
using BeerCellar.DataAccess;
using BeerCellar.Models;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace BeerCellar
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();
			services.AddTransient<BeerCellarQuery>();
			services.AddSingleton<IBeerCellarFetcher, BeerCellarFetcher>();
			services.AddSingleton<BeerCellarSchema>(
				x => new BeerCellarSchema(
					type => (IGraphType)x.GetService(type)));
			services.AddTransient<IDocumentExecuter, DocumentExecuter>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }			
            app.UseDefaultFiles();
            app.UseStaticFiles();
			app.UseMvc();
		}
	} }