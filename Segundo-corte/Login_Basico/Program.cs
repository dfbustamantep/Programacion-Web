var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSession(options =>
{
    //Tiempo maximo que una sesion puede estar inactiva antes de caducar 30 minutos
	options.IdleTimeout = TimeSpan.FromMinutes(30); // Tiempo de inactividad
    //Aumenta la seguridad 
	options.Cookie.HttpOnly = true;
    //PErmite que la cookie de sesion se utilice incluso si el usuario ha rechazado otras cookies no esenciales
	options.Cookie.IsEssential = true;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseSession();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
