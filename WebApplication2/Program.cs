var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



    app.Use(async (context, next) =>
    {
       await context.Response.WriteAsync("Middle ware 1! ");
       await next.Invoke();
       await context.Response.WriteAsync("Middle ware 1 response! ");
    });
    app.Use(async (context, next) =>
    {
       await context.Response.WriteAsync("Middle ware 2! ");
       await next.Invoke();
       await context.Response.WriteAsync("Middle ware 2 Response! ");
    });
    app.MapGet("/",async context =>
    {
        await context.Response.WriteAsync("Hello World!");
        
    });
    app.Run();
