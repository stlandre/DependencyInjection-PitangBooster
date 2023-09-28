using pitang.booster.dependency.injection._1._2.Business;
using pitang.booster.dependency.injection._1._2.IBusiness;
using pitang.booster.dependency.injection._1._2.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<PrimeiroServico>();
builder.Services.AddScoped<SegundoServico>();
builder.Services.AddTransient<TerceiroServico>();

builder.Services.AddScoped<IApplicationBusiness, ApplicationBusiness>();

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

// Referencias
// www.youtube.com/watch?v=9n0jOl7L9oM&ab_channel=balta.io
// www.youtube.com/watch?v=but7jqjopKM&ab_channel=balta.io
// dev.to/wandealves/entendendo-a-injecao-de-dependencia-uma-abordagem-para-um-codigo-mais-flexivel-e-testavel-1ik4
// marcionizzola.medium.com/afinal-o-que-%C3%A9-inje%C3%A7%C3%A3o-de-depend%C3%AAncia-68131c864a79
