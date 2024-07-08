using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using prsServer.Data;
namespace prsServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<prsServerContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("prsServerContext") ?? throw new InvalidOperationException("Connection string 'prsServerContext' not found.")));

            // Add services to the container.

            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
