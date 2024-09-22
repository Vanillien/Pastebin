using Microsoft.AspNetCore.Connections;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Pastebin1.Classes;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options => //выполняетъ функционалъ OnConfiguring()
{
    options.LogTo(Console.WriteLine);
        
    options.UseNpgsql("Server=127.0.0.1;Port=5432;Database=Pastebin;User Id=postgres;Password=password");
});

/*
using (ApplicationDBContext dbContext = new ApplicationDBContext())
{
    User user1 = new User("Googendochen", "pupik123@gmail.com", "12345678");
    User user2 = new User("Scheubengoogenschmeck", "popkokusatel999@gmail.com", "password");
    
    dbContext.Users.AddRange(user1, user2); //сей методъ добавляетъ сущности в базу данныхъ
    dbContext.SaveChanges(); //сохраняемъ изменения
}

using (ApplicationDBContext dbContext = new ApplicationDBContext())
{
    var userList = dbContext.Users.ToList(); //сей методъ возвращаетъ списокъ Users изъ базы данныхъ
}
*/

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


