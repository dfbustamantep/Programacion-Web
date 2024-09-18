var builder = WebApplication.CreateBuilder(args);
// Indicamos que se ejecutara una pagina Razor
builder.Services.AddRazorPages();
var app = builder.Build();
app.MapRazorPages();
//app.MapGet("/", () => "Hello World!");

app.Run();
