using API.Middleware;
using API.StartupExtensions;

var builder = WebApplication.CreateBuilder(args);

var piccoAppCorsPolicy = "CorsPolicy";

// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

builder.Services.ConfigureSwaggerServices();

builder.Services.AddCors(option => {
    option.AddPolicy(piccoAppCorsPolicy, policy => {
        policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4200");
    });
});

builder.Services.ConfigureServices(builder.Configuration, builder.Environment);

var app = builder.Build();

app.UseExceptionHandlingMiddleware();

// app.UseSwagger();
// app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// re-execute pipeline with alternate path in case user try to reach an unavailable controller or action method
app.UseStatusCodePagesWithReExecute("/Errors/{0}");

app.UseHttpsRedirection();

app.UseRouting();

app.UseStaticFiles();

app.UseCors(piccoAppCorsPolicy);

app.UseHttpsRedirection();


app.UseAuthorization();

app.UseSwaggerDocumentation();

app.MapControllers();

app.Run();