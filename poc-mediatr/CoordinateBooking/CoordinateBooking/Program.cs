using CoordinateBookingHandlers;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using SayanInvestorAuditing;
using System.Reflection;

WebApplicationBuilder hostBuilder = WebApplication.CreateBuilder(args);

hostBuilder.Services.AddControllers();
hostBuilder.Services.AddMediatR(Assembly.GetExecutingAssembly());

hostBuilder.Services.AddBookingHandlers();

hostBuilder.Services.AddSayanAuditings();

hostBuilder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "CoordinateBooking", Version = "v1" });
});

await using WebApplication application = hostBuilder.Build();

application.MapControllers();

if (application.Environment.IsDevelopment())
{
    application.UseDeveloperExceptionPage();
    application.UseSwagger();
    application.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CoordinateBooking v1"));
}

await application.RunAsync();