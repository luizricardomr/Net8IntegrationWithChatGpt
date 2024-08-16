using ChatGPT.ASPNET.Integration.Extensions;

var builder = WebApplication.CreateBuilder(args);

string appName = "ChatGpt ASPNET 8 Integration";

builder.AddChatGpt(builder.Configuration);
builder.AddSerilog(builder.Configuration, appName);
builder.Services.AddControllers();
builder.Services.AddSwagger(builder.Configuration, "ChatGPT ASP.NET 8 Integration");
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UserSwaggerDoc(appName);
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
