using CryptoSpect.DA.Repositories;
using CryptoSpect.Core.Interfaces;
using CryptoSpect.Service.Implementations;
using CryptoSpect.Service.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Register repositories
builder.Services.AddScoped<ICryptocurrencyRepository, CryptocurrencyRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ITransactionHistoryRepository, TransactionHistoryRepository>();

// Register services
builder.Services.AddScoped<ICryptocurrencyService, CryptocurrencyService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ITransactionHistoryService, TransactionHistoryService>();

builder.Services.AddLogging();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

await app.RunAsync().ConfigureAwait(false);
