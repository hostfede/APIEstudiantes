using Microsoft.AspNetCore.Authentication.JwtBearer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Configuracion para Validar Autenticacion.
builder.Services.AddAuthentication(options  =>
{
	options.DefaultAuthenticateScheme  =  JwtBearerDefaults.AuthenticationScheme;
	options.DefaultChallengeScheme  =  JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options  =>
{
	// Agregar URL de su cuenta de Auth0 de cada uno.
	options.Authority  =  "https://dev-a0hk71n1s62bkzxy.us.auth0.com/";
	// Agregar audiencia de la API.
	options.Audience  =  "https://api.example.com/estudiantes";
});

var  app  =  builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Habilitamos Autenticacion.
app.UseAuthentication();

//Habilitamos Autorización. 
app.UseAuthorization();

app.MapControllers();

app.Run();
