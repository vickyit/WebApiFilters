
using WebApiClass.Filters;
using WebApiClass.Middlewares;

namespace WebApiClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers( option =>
            {
                option.Filters.Add<ExecptionFilter>();
            });


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



            app.Use(async (context, next) => {

                Console.WriteLine("middleware 1 ...start");
                Console.WriteLine(context.Request.Path);
                await next();

                Console.WriteLine("middleware 1 ...end");


            });

            app.Use(async (context, next) => {

                Console.WriteLine("middleware 2 ...start");
                Console.WriteLine(context.Request.Path);
                 
                await next();

                Console.WriteLine("middleware 2 ...end");


            });

            app.UseMiddleware<TestMiddleware>();

            app.MapControllers();

            app.Run();
        }
    }
}
