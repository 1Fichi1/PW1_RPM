var builder = WebApplication.CreateBuilder(args);

// Добавляем поддержку контроллеров с представлениями (MVC)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Настройка middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Маршрутизация по умолчанию
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Маршрут для корзины (внутри CatalogController)
app.MapControllerRoute(
    name: "cart",
    pattern: "Cart",
    defaults: new { controller = "Catalog", action = "Cart" });

// Маршрут для страницы "Политика конфиденциальности" (внутри PrivacyPolicyController)
app.MapControllerRoute(
    name: "privacy",
    pattern: "PrivacyPolicy",
    defaults: new { controller = "PrivacyPolicy", action = "Index" });

app.Run();
