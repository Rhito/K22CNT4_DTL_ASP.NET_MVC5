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
        name: "Show Product",
        pattern: "San-Pham/Danh-Sach-San-Pham",
        defaults: new { controller = "DtlProduct", action = "DtlShowProduct" });

    endpoints.MapControllerRoute(
        name: "Product",
        pattern: "San-Pham",
        defaults: new { controller = "DtlProduct", action = "DtlShowProduct" });

    endpoints.MapControllerRoute(
        name: "Edit Product",
        pattern: "San-Pham/Sua/{productId}",
        defaults: new { controller = "DtlProduct", action = "DtlEditProduct", productId = @"\d{1,4}" });

    endpoints.MapControllerRoute(
        name: "Details Product",
        pattern: "San-Pham/{productName}/{productId}",
        defaults: new { controller = "DtlProduct", action = "DtlDetailsProduct", productName = (string)null ,productId = @"\d{1,4}" });

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
