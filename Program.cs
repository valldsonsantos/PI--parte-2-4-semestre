using Microsoft.EntityFrameworkCore;
using TarefasAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Configurar conexão com SQLite
builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseSqlite("Data Source=tarefas.db"));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();