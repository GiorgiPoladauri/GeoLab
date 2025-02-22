using Microsoft.EntityFrameworkCore;
using LibraryManagementProj.Infrastructure.Data;
using LibraryManagementProj.Core.Interfaces.IRepositories;
using LibraryManagementProj.Infrastructure.Repositories;
using LibraryManagementProj.Application.Services.Abstractions;
using LibraryManagementProj.Application.Services.Implementation;

namespace LibraryManagementProj.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();

            // Register the EF Core DbContext using the connection string from appsettings.json
            builder.Services.AddDbContext<LibraryContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("LibraryManagementDbConnection")));

            // Register your repository and service layers
            builder.Services.AddScoped<IBookRepository, BookRepository>();
            builder.Services.AddScoped<IBookService, BookService>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
