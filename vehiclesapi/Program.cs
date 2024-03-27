using carsang.Data;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

namespace vehiclesapi
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			//			builder.Services.AddEndpointsApiExplorer();
			//			builder.Services.AddSwaggerGen();
			var vehicles_connectionString = builder.Configuration.GetConnectionString("MSSQLConnection");
			builder.Services.AddDbContext<VehiclesDbTempContext>(options => options.UseSqlServer(vehicles_connectionString));
			//builder.Services.AddDbContext<VehiclesDbTempContext>(vehicles_connectionString);
	/*		builder.Services.AddCors(options =>
			{
				options.AddPolicy(name: MyAllowSpecificOrigins,
								  policy =>
								  {
									  
									  policy.AllowAnyHeader();
									  policy.AllowAnyMethod();
									  policy.AllowAnyOrigin();
								  });
			});*/

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				//				app.UseSwagger();
				//				app.UseSwaggerUI();
			}

//			app.UseHttpsRedirection();

//			app.UseAuthorization();

//			app.UseCors();
			app.MapControllers();
			app.MapControllerRoute(
			name: "default",
			pattern: "{controller = Home}/{action=Index}/{id?}");

			app.MapControllerRoute(
			name: "api",
			pattern: "/api/{controller = Vehicles}/{action=Get}/{id?}");
		
		

			//			app.UseRouting();
						app.UseDefaultFiles();
						app.UseStaticFiles(new StaticFileOptions
						{
							ServeUnknownFileTypes = true,
							FileProvider = new PhysicalFileProvider(
		Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")),
							RequestPath = "/StaticFiles"
						});
			app.UseRouting();
			app.Run();

		}
	}
}