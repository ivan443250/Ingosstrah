var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => File.ReadAllText("index.html"));

app.Run();
