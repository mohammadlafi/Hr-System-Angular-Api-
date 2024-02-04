using AutoMapper;
using HrApi.Data;
using HrApi.Serves;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<ICountryeInterFace,CountryServes>();
builder.Services.AddScoped<IEmployeeInterFace,EmployeeServes>();
builder.Services.AddScoped<IDepartemntInterFace,DepartemntServes>();
builder.Services.AddScoped<ICityInterFac,CityServes>();
builder.Services.AddDbContext<HrContext>();
builder.Services.AddControllers().AddNewtonsoftJson();


builder.Services.AddCors(opt =>
{
    opt.AddPolicy("loginOrgin", builder =>
    {
        builder.AllowAnyMethod();
        builder.AllowAnyOrigin();
        builder.AllowAnyHeader();
    });
});

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("loginOrgin");
app.UseAuthorization();

app.MapControllers();

app.Run();
