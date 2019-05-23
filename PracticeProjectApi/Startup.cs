using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PracticeProjectApi.Models;
using Swashbuckle.AspNetCore.Swagger;

namespace PracticeProjectApi
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
			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

			//REGISTERING THE DBCONTEXT
			services.AddDbContext<PracticeContext>(optn =>
			{
				optn.UseInMemoryDatabase("PracticeList");
			});


			//====================================================================
			//====================================================================
			//REGISTER THE SWAGGERGENERATOR, DEFINING 1 OR MORE SWAGGER DOCUMENTS
			//====================================================================
			//====================================================================
			services.AddSwaggerGen(config =>
			{
				config.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
			});

		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{

			//===================================================
			//===================================================
			//CONFIGURE PROJECT TO USE SWAGGER
			//CONFIGURE SWAGGERUI TO CREATE THE SWAGGER ENDPOINT
			//===================================================
			//===================================================
			app.UseSwagger();
			app.UseSwaggerUI(config =>
			{
				config.SwaggerEndpoint("/swagger/v1/swagger.json", "MY API V1");
			});








			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseMvc();
		}
	}
}
