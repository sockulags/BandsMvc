var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseRouting();
app.UseEndpoints(x=>x.MapControllers());
app.UseStaticFiles();
app.Run();
