var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
    var todo = new Todo(Guid.NewGuid(), "An awesome minimal api", true);
    return Results.Ok(todo);
});

app.Run();
