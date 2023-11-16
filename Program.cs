namespace HexaShopF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            builder.Services.AddControllersWithViews();

            app.MapControllerRoute(
                name: "Default",
                pattern: "{controller}/{action}/{id}"
                );
            app.UseStaticFiles();
            app.Run();
        }
    }
}