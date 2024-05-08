

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "NhacVietPlaylist",
        pattern: "Play_List/Nhac_Viet",
        defaults: new { controller = "Home", action = "NhacViet" });

    endpoints.MapControllerRoute(
       name: "PlayList",
       pattern: "Play_List",
       defaults: new { controller = "Home", action = "NhacViet" });

    endpoints.MapControllerRoute(
       name: "PlayBack",
       pattern: "Play Back/{name}",
       defaults: new { controller = "Home", action = "PhatNhac", name = (string)null });

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

});

app.Run();