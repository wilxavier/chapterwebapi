using Chapter.WebApi.Contexts;
using Chapter.WebApi.Repositories;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ChapterContext,ChapterContext>();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
})

app.Run();
