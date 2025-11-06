var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



    app.Use(async (context, next) =>
    {
       await context.Response.WriteAsync("Middle ware!");
       await next.Invoke();
    });
    app.MapGet("/",async context =>
    {
        await context.Response.WriteAsync("Hello World!");
    });
    app.Run();
