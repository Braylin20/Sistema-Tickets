using Microsoft.EntityFrameworkCore;
using RegPrioridades.BLL;
using RegPrioridades.Components;
using RegPrioridades.DAL;
using RegPrioridades.Services;

namespace RegPrioridades
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.2
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            var ConStr = builder.Configuration.GetConnectionString("ConStr");

            builder.Services.AddDbContext<Contexto>(options => 
                options.UseSqlite(ConStr));

            builder.Services.AddScoped<PrioridadesService>();
            builder.Services.AddScoped<ClientesService>();
            builder.Services.AddScoped<TicketsService>();

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
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
