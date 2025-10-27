var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Content(
    "<html><head><meta charset='utf-8'><title>Azure</title></head>" +
    "<body style='font-family:system-ui;margin:2rem'>" +
    "<h1>Witaj w Azure App Service 🚀</h1><p>ASP.NET Core minimal API</p>" +
    "</body></html>", "text/html"));

app.Run();
