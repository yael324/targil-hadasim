using BL.Classes;
using DAL.Classes;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<IEmployeeBL, EmployeeBL>();
builder.Services.AddScoped<ISickBL, SickBL>();
builder.Services.AddScoped<IVaccinationBL, VaccinationBL>();

builder.Services.AddScoped<IEmployeeDAL, EmployeeDAL>();
builder.Services.AddScoped<ISickDAL, SickDAL>();
builder.Services.AddScoped<IVaccinationDAL, VaccinationDAL>();
builder.Services.AddDbContext<HealthFundManagerContext>(options =>
options.UseSqlServer("Server=DESKTOP-QCFGMTI\\SQLEXPRESS;Database=HealthFundManagement;Trusted_Connection=True;TrustServerCertificate=True;"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
