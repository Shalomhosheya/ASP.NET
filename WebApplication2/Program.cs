using Microsoft.Extensions.FileProviders;

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

    // ✅ Default route — fallback
    /*
    app.MapGet("/", async context =>
    {
        context.Response.ContentType = "text/html";
        await context.Response.SendFileAsync("wwwroot/index.html");
    });
    app.Map("/path1", path1);
    app.Run();
    */


   /*app.Map("/path1", path1);
   app.Map("/path2", path2);
   */
   

    /*static void path1(IApplicationBuilder app)
    {
        app.Run(async context =>
            {
                await context.Response.WriteAsync("Path1 is 1!");
            }
        );
    }*/
    
    /*static void path2(IApplicationBuilder app)
    {
        app.Run(async context =>
            {
                await context.Response.WriteAsync("Path2 is 2!");
            }
        );
    }*/
/*app.UseStaticFiles(new StaticFileOptions()
{
   FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "staticFiles")),
   RequestPath = new PathString("/staticFiles")
});


app.UseDirectoryBrowser(new DirectoryBrowserOptions()
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot","images")),
    RequestPath = new PathString("/images")
});*/
    var files = new DefaultFilesOptions();
    files.DefaultFileNames.Clear();
    files.DefaultFileNames.Add("hworld.html");
    files.DefaultFileNames.Add("index.html");

app.UseDefaultFiles(files);
app.UseStaticFiles();
app.Run();
