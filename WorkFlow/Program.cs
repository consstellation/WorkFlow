using WorkFlow.Services;

var builder = WebApplication.CreateBuilder(args); //создаём объект для подготовки приложения

// Add services to the container.

builder.Services.AddControllers(); //регистрируем необходимые сервисы
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//для передачи контроллера
builder.Services.AddSingleton<ITaskService, TaskService>();

var app = builder.Build(); //созаём веб-приложение на основе настроек

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers(); //настраиваем маршруты контроллеров

app.Run();
