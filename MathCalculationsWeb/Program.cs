﻿using MathFunctions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapGet("/add", () =>
{
    // Declare Functions class which is available in MathFunctions.Dll
    Functions mathFunctions = new Functions();

    // Access Add method from the class library
    var add = mathFunctions.Add(20, 10);

    return add;
});

app.Run();
