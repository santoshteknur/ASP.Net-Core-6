var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseRouting();

//app.MapGet("/", () => "Worker Process Name : " + System.Diagnostics.Process.GetCurrentProcess().ProcessName);

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is MapGet response..");
    });

    endpoints.MapPost("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is MapPost response..");
    });

});

app.Run( async (HttpContext context) =>
{
    await context.Response.WriteAsync("Page Not Find");
});

app.Run();

