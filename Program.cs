using Microsoft.AspNetCore.Mvc.Razor.Compilation;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/Views/TimeClockUI", () => "");

app.Run();