using AnimalsShelter.Repositories;
using AnimalsShelter.Services;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddControllers().AddXmlSerializerFormatters();
        builder.Services.AddScoped<IAnimalsRepository, AnimalsRepository>();
        builder.Services.AddScoped<IAnimalsService, AnimalsService>();
        builder.Services.AddScoped<IVisitsRepository, VisitsRepository>();
        builder.Services.AddScoped<IVisitsService, VisitsService>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.MapControllers();

        app.Run();
    }
}