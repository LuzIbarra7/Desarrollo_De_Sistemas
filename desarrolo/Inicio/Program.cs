var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // Habilita el servicio de archivos estáticos (CSS, JS, imágenes)

app.UseRouting();

app.UseAuthorization();

// ¡AÑADE ESTA LÍNEA AQUÍ! Redirige la URL raíz ("/") a "/Login"
app.MapGet("/", context => {
    context.Response.Redirect("/Login");
    return Task.CompletedTask;
});

app.MapRazorPages(); // Esta línea debe ir DESPUÉS de la redirección

app.Run();
