
using AplicacaoEnrity.Data;
using AplicacaoEnrity.Repositoy;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Conexao>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoBanco")));


//definindo o tipo de servico usado para o repository e interface
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository >();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
