using ElectroniqueApi.Services;
using Microsoft.EntityFrameworkCore;
using ElectroniqueApi.Controllers;
using ElectroniqueApi.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContextPool<AppDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ElectroniqueApiContext"
)));
builder.Services.AddScoped<IProduitService<Produit>,ProduitService>();
builder.Services.AddScoped<ICllientService<Client>, ClientService>();
builder.Services.AddScoped<ICategorieService<Categorie>, CategorieService>();
builder.Services.AddScoped<IFactureLigneService<LigneFacture>, FactureLigneService>();
builder.Services.AddScoped<IFactureService<Facture>, FactureService>();
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
