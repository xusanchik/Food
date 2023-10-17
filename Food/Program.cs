using Food.Data;
using Food.Interface;
using Food.Repastorys;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IFoodRepastory, FoodRepastory>();
builder.Services.AddScoped<IFunctionsRepastory ,FunctionsRepastory>();
builder.Services.AddScoped<IInformationRepastory,InformationRepastory>();
builder.Services.AddScoped<ILenguageRepastory,LenguageRepastory>();
builder.Services.AddScoped<IMenuRepastorycs, MenuRepastory>();
builder.Services.AddScoped<IOrderHistoryRepastory,OrderHistoryRepastory>();
builder.Services.AddScoped<IOrderRepastory, OrdersRepastory>();
builder.Services.AddScoped<IPaymentRepastory,PaymentRepastory>();
builder.Services.AddScoped<IProfileRepastory , ProfileRepastory>();
builder.Services.AddScoped<IRegistrationRepastory , RegistrationRepastory>();
builder.Services.AddScoped<IUserRepastory ,UserRepastory>();


builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
