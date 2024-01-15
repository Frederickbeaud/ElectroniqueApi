using ElectroniqueApi.Services;
using Microsoft.EntityFrameworkCore;
using ElectroniqueApi.Controllers;
using ElectroniqueApi.Model;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContextPool<AppDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ElectroniqueApiContext"
)));
builder.Services.AddTransient<IProduitService<Produit>,ProduitService>();
builder.Services.AddTransient<ICllientService<Client>, ClientService>();
builder.Services.AddTransient<ICategorieService<Categorie>, CategorieService>();
builder.Services.AddTransient<IFactureLigneService<LigneFacture>, FactureLigneService>();
builder.Services.AddTransient<IFactureService<Facture>, FactureService>();
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

app.UseCors(builder => builder.WithOrigins("http://localhost:3000"));

app.Run();
