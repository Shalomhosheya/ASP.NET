var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



    app.Use(async (context, next) =>
    {
        var key = context.Request.Query["key"];
        if (!string.IsNullOrWhiteSpace(key))
        {
            if (key == "ABC123")
            {
              await context.Response.WriteAsync(" You are authorize ");
            }
            await next();
        }
    });

    /*app.Use(async (context, next) =>
    {
       await context.Response.WriteAsync("Middle ware 2! ");
       await next.Invoke();
       await context.Response.WriteAsync("Middle ware 2 Response! ");
    });*/
    app.MapGet("/",async context =>
    {
        await context.Response.WriteAsync("Hello World!");
        
    });
    app.Run();
