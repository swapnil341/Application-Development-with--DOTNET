var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); // Enable controllers 

// ✅ Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();   // Enables swagger

var app = builder.Build();

// ✅ Enable Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();  // Connect controller to map

app.Run();


/*
Activity
which HTTP method we are using 
what is endpoint
which response we get
understand the flow of web api with swagger

webapi means communication
controllers - handlers
http metods - actions
swagger - testing tools
*/