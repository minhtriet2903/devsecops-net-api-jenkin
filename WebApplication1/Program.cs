using Microsoft.EntityFrameworkCore;
using Prometheus;
using WebApplication1.Db;
using WebApplication1.Interfaces;
using WebApplication1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Configure in memory database
builder.Services.AddDbContext<HRMContext>(opt => opt.UseInMemoryDatabase("HRMDB"));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Register DI
builder.Services.AddScoped<IEmployeeService, EmployeeService>();

var app = builder.Build();

// 2. Find the service within the scope to use
using (var scope = app.Services.CreateScope())
{
    // 3. Get the instance of HRMContext in our service layer
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<HRMContext>();

    // 4. Call the SeedDataGenerator to generate seed data
    SeedDataGenerator.Initialize(services);
}

app.UseMetricServer();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

//adding metrics related to HTTP
app.UseHttpMetrics(options =>
{
    options.AddCustomLabel("host", context => context.Request.Host.Host);
});

app.UseAuthorization();

app.MapControllers();

app.Run();
