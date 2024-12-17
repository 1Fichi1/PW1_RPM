var builder = WebApplication.CreateBuilder(args);

// ��������� ��������� ������������ � ��������������� (MVC)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// ��������� middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ������������� �� ���������
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// ������� ��� ������� (������ CatalogController)
app.MapControllerRoute(
    name: "cart",
    pattern: "Cart",
    defaults: new { controller = "Catalog", action = "Cart" });

// ������� ��� �������� "�������� ������������������" (������ PrivacyPolicyController)
app.MapControllerRoute(
    name: "privacy",
    pattern: "PrivacyPolicy",
    defaults: new { controller = "PrivacyPolicy", action = "Index" });

app.Run();
