using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using NorthwindBlazorServer.Data;
using Microsoft.AspNetCore.ResponseCompression;
using NorthwindBlazorServer.Hubs;
using NorthwindBlazorServer.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddResponseCompression(opts =>
{
	opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
		  new[] { "application/octet-stream" });
});

builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddDbContextFactory<NorthwindContext>(options =>
			options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Northwind;Trusted_Connection=True;"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
}

app.UseResponseCompression();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();

app.MapHub<ChatHub>("/chathub");

app.MapFallbackToPage("/_Host");

app.Run();
