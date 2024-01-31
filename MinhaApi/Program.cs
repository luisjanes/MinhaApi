
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!!");
app.MapGet("/hello", Hello);
app.MapGet("/hello{name}", HelloName);
app.MapPost("/", (User user) =>
{
    return Results.Ok(user);
});


app.MapGet("/user{id}", () =>
{
    return Results.Ok("User Luis Felipe");
});

app.Run();

string HelloName(string name)
{
    return $"User {name}";
}
string Hello()
{
    return "Hello world with separetade function";
}

public class User 
{
    public int Id { get; set; }
    public string Username { get; set; }
}
