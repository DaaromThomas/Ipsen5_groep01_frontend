using Blazored.LocalStorage;
using Blazored.SessionStorage;
using Ipsen5_groep01_frontend.Components;

using Microsoft.AspNetCore.Authentication.JwtBearer;

using Ipsen5_groep01_frontend.Components.Services;
using Ipsen5_groep01_frontend.Components.Layout;


var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredSessionStorage();


builder.Services.AddSingleton<DocumentenService>();
builder.Services.AddSingleton<DossiersService>();
builder.Services.AddSingleton<UploadTypeService>();
builder.Services.AddSingleton<LoginService>();
builder.Services.AddSingleton<FileUploadService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();