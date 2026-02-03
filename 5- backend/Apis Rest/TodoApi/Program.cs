using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
namespace TodoApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            // 1) Controllers: habilita rotas baseadas em controllers.
            builder.Services.AddControllers();

            // 2) DbContext: banco em memoria (bom para estudo).
            builder.Services.AddDbContext<TodoContext>(opt =>
                opt.UseInMemoryDatabase("TodoList"));

            // 3) Swagger: documentacao automatica da API.
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            // Swagger UI: ajuda a testar endpoints.
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Todo API V1");
                c.RoutePrefix = string.Empty; // serve the UI at application's root
            });

            // Redireciona HTTP -> HTTPS.
            app.UseHttpsRedirection();

            // Autorizacao (nao ha auth configurada ainda, mas o middleware e mantido).
            app.UseAuthorization();

            // Mapeia controllers (rotas).
            app.MapControllers();

            app.Run();
        }
    }
}
