var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

var port = Environment.GetEnvironmentVariable("WEBSITES_PORT") ?? "80";
app.Urls.Add($"http://0.0.0.0:{port}");

app.MapGet("/", () => "Hello World!");
app.MapGet("/api/hello", () => "Hello World!");

app.Run();
