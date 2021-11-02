using Api.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
    var todo = new Todo(Guid.NewGuid(), "Todo", true);
    return Results.Ok(todo);
});

app.Run();
