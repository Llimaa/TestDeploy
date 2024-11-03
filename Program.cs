var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://*:80");

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/api/hello", () => "Hello World!");

app.Run();
