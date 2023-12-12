var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseRouting();

//MapGet Method use only for Get request
//app.MapGet("/Get", () => "MApGet Worker Process Name : " + System.Diagnostics.Process.GetCurrentProcess().ProcessName);

// Map method is used for all request
//app.Map("/", () => "Worker Process Name : " + System.Diagnostics.Process.GetCurrentProcess().ProcessName);


//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapGet("/Home", async (context) =>
//    {
//        await context.Response.WriteAsync("This is MapGet response..");
//    });

//    endpoints.MapPost("/Home", async (context) =>
//    {
//        await context.Response.WriteAsync("This is MapPost response..");
//    });

//});

app.MapControllerRoute(
    name: "default",
    pattern: "{Controller=Home}/{action=Index}/{id?}"
    );

//app.Run( async (HttpContext context) =>
//{
//    await context.Response.WriteAsync("Page Not Find");
//});

app.Run();

