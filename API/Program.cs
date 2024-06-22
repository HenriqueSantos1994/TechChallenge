using FIAP.TechChallenge.ByteMeBurguer.API.Extensions;
using FIAP.TechChallenge.ByteMeBurguer.Application;
//using FIAP.TechChallenge.ByteMeBurguer.Infra.Data.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Thread.Sleep(15000);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddProjectDependencies();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI(s =>
    {
        s.SwaggerEndpoint("/swagger/v1/swagger.json", "Tech Challenge");
    });
//}

//app.MigrationInitial();
using (var scope = app.Services.CreateScope())
{
    var initializer = scope.ServiceProvider.GetRequiredService<IDatabaseInitializer>();
    initializer.Initialize();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
