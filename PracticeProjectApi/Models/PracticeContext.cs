using Microsoft.EntityFrameworkCore;

namespace PracticeProjectApi.Models
{
	//==========================================================
	//*****AFTER***** CREATING THIS, YOU THEN HAVE TO REGISTER THIS 
	//IN THE STARTUP.CS.......EX W/ IN MEMORY DB:
	//            services.AddDbContext<TodoContext>(opt =>
	//                opt.UseInMemoryDatabase("TodoList"));
	//
	//						**OR**
	//
	//
	//					services.AddDbContext<EntitiesContext>(options =>
	//				{
	//				#if DEBUG
	//				options.UseSqlServer(Configuration.GetConnectionString("VodLibrary"));
	//				#else
	//								var rdsEndpoint = System.Environment.GetEnvironmentVariable("RDSEndpoint");
	//								var environment = System.Environment.GetEnvironmentVariable("Environment");
	//								options.UseSqlServer($"Data Source={rdsEndpoint};initial catalog={environment}VodLibrary;persist security info=True;user id=userName;password=passowordHere;MultipleActiveResultSets=True;App=EntityFramework;");
	//				#endif
	//				});
	//==========================================================

	public class PracticeContext : DbContext
	{
		//add DbContextOptions and pass it into the constructor
		public PracticeContext(DbContextOptions<PracticeContext> options)
			: base(options) { }

		//remember a dbset represents a set of entities and their ability to CRUD
		public DbSet<PracticeItem> PracticeItems { get; set; }

	}
}
