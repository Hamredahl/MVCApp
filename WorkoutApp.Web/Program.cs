using WorkoutApp.Web.Services;

namespace WorkoutApp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<ExerciseService>();
            var app = builder.Build();

            app.UseStaticFiles();
            app.MapControllers();

            app.Run();
        }
    }
}
