using EMS.BAL.Services;
using EMS.DAL.Data;
using EMS.DAL.Repository;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connstring = builder.Configuration.GetConnectionString("postgresconnection");

builder.Services.AddControllers();

builder.Services.AddDbContext<EMSDbContext>(options => options.UseNpgsql(connstring));
//Adding Scopes for Equipments
builder.Services.AddScoped<IEquipmentRepository, EquipmentRepository>();
builder.Services.AddScoped<EquipmentService,EquipmentService>();

//Adding Scopes for Technician
builder.Services.AddScoped<ITechnicianrepository, TechnicianRepository>();
builder.Services.AddScoped<TechnicianService, TechnicianService>();

//Adding Scopes for Sensor
builder.Services.AddScoped<ISensorRepository,SensorRepository>();
builder.Services.AddScoped<SensorService, SensorService>();

//Adding scopes for Maintenance
builder.Services.AddScoped<IMaintenanceRepository, MaintenanceRepository>();    
builder.Services.AddScoped<MaintenanceService, MaintenanceService>();

builder.Services.AddScoped<IAnamolyRepository, AnamolyRepository>();
builder.Services.AddScoped<AnamolyService, AnamolyService>();

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
app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000"));
app.UseAuthorization();

app.MapControllers();

app.Run();
