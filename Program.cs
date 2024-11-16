var builder = WebApplication.CreateBuilder(args);

// MVC servislerini ekler
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Statik dosyaların kullanılabilmesi için middleware ekler
app.UseStaticFiles();

// Routing yapılandırması
app.UseRouting();

// Varsayılan routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();

/* Açıklamalar:
 * Controller: MVC'nin C (Controller) kısmını temsil eder. İstekleri işler ve uygun bir yanıt döndürür.
 * Action: Controller içinde bir metodun ismine karşılık gelir ve spesifik bir isteği işler.
 * Model: Veritabanından veya başka bir veri kaynağından alınan veriyi temsil eder.
 * View: Kullanıcıya görsel olarak sunulan çıktıdır. HTML sayfalarıdır.
 * Razor: ASP.NET Core'un View kısmında HTML ile C# kodlarını birleştirmek için kullandığı bir sözdizimidir.
 * RazorView: Razor ile oluşturulan View'lerin işlenmiş halidir.
 * wwwroot: Statik dosyalar (CSS, JS, resim dosyaları) bu klasörde tutulur.
 * builder.Build(): Uygulama nesnesini oluşturur ve yapılandırmayı tamamlar.
 * app.Run(): Uygulamayı başlatır ve gelen istekleri işlemeye hazır hale getirir.
 */
