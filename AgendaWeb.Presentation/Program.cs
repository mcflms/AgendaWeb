using AgendaWeb.Infra.Data.Interfaces;
using AgendaWeb.Infra.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

//configurando o projeto para MVC
builder.Services.AddControllersWithViews();

//capturar a connectionstring mapeada no appsettings.Json
var connectionString = builder.Configuration.GetConnectionString("AgendaWeb");

// Enviar a connectionstring mapeada no appsettings.json
builder.Services.AddTransient<IEventoRepository>
    (map => new EventoRepository(connectionString));


var app = builder.Build();

//configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Definiindo a pagina inicial do projeto 
app.MapControllerRoute(
    name: "default",pattern: "{controller=Home}/{action=Index}"
    );

app.Run();
