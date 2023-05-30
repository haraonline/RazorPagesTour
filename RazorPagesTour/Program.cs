namespace RazorPagesTour;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddRazorPages(); // Add services to the container.
        var app = builder.Build();
                
        if (!app.Environment.IsDevelopment()) // Configure the HTTP request pipeline (MIDDLEWARE COMPONENTS)
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }
        
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseHttpLogging();
        app.UseAuthorization();
        app.MapRazorPages();
        app.Run();
    }
}