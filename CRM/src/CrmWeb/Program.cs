using CrmWeb.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCrmServices();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

if (app.Environment.IsDevelopment() || app.Environment.EnvironmentName.Equals("Docker"))
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();

app.MapControllers();

app.UseEndpoints(endPoints => { });

app.Run();
