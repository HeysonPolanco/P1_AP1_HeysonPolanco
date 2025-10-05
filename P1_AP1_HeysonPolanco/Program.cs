using P1_AP1_HeysonPolanco.Components;
using Microsoft.EntityFrameworkCore;
using P1_AP1_HeysonPolanco.DAL;
using P1_AP1_HeysonPolanco.Models;
using P1_AP1_HeysonPolanco.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var ConStr = builder.Configuration.GetConnectionString("SqlConnection");
builder.Services.AddDbContextFactory<Context>(o => o.UseSqlite(ConStr));

builder.Services.AddScoped<EntradasGuacalesService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAntiforgery();
app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
