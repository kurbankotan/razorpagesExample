using Microsoft.EntityFrameworkCore;

namespace razorpagesExample.Models;

public class DataContext:DbContext
{
    public DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //ConnectionStrin'i appsettings.json dosyasına yazmak yerine aşağıyada bu şekilde yazabiliriz
        optionsBuilder.UseSqlite(@"Data Source = Razor.Db");
    }
}