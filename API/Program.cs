using Infra.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
Thread.Sleep(15000);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.RegisterDependence();

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

app.MigrationInitial();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
