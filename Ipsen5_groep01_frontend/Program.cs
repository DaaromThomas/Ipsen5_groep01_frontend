using System.Text.Json;
using Blazored.LocalStorage;
using Blazored.SessionStorage;
using Ipsen5_groep01_frontend.Components;
using Ipsen5_groep01_frontend.Services;
 
 
var builder = WebApplication.CreateBuilder(args);
 

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
 
builder.Services.AddHttpClient();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredSessionStorage();
builder.Services.AddSingleton<AuthService>();
builder.Services.AddSingleton<LoginService>();
builder.Services.AddSingleton<ContractService>();
builder.Services.AddSingleton<RequestMakerService>();
builder.Services.AddSingleton<JsonKeyConverter>();
builder.Services.AddAuthorizationCore();
 
 
builder.Services.AddSingleton<AuthService>();
 
builder.Services.AddSingleton<UploadTypeService>();
builder.Services.AddSingleton<LoginService>();
builder.Services.AddSingleton<FileUploadService>();
builder.Services.AddSingleton<CandidateService>();
builder.Services.AddSingleton<TemplateUploadService>();
builder.Services.AddSingleton<NotificatieService>();
builder.Services.AddSingleton<GetColorService>();
 
 
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