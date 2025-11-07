var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



    /*app.Use(async (context, next) =>
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
    });*/

    /*app.Use(async (context, next) =>
    {
       await context.Response.WriteAsync("Middle ware 2! ");
       await next.Invoke();
       await context.Response.WriteAsync("Middle ware 2 Response! ");
    });*/

    app.Use(async (context, next) =>
    {
       await context.Response.WriteAsync("Hello World! ");
       await next.Invoke();
    });

    
   app.Map("/path1", path1);
   app.Map("/path2", path2);
   
    app.Run();

    static void path1(IApplicationBuilder app)
    {
        app.Run(async context =>
            {
                await context.Response.WriteAsync("Path1 is 1!");
            }
        );
    }
    static void path2(IApplicationBuilder app)
    {
        app.Run(async context =>
            {
                await context.Response.WriteAsync("Path2 is 2!");
            }
        );
    }
