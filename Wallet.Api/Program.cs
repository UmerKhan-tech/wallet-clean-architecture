using Microsoft.EntityFrameworkCore;
using Wallet.Infrastructure.Data;
using Wallet.Application.Interfaces;
using Wallet.Infrastructure.Services;
using Wallet.Application.Repositories;
using Wallet.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// DB Connection
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        b => b.MigrationsAssembly("Wallet.Infrastructure")
    )
);

// DI
builder.Services.AddScoped<IWalletRepository, WalletRepository>();
builder.Services.AddScoped<IWalletService, WalletService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();