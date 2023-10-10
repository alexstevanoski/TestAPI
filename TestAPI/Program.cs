using Microsoft.EntityFrameworkCore;
using TestAPI.Data;
using TestAPI.Models;

builder.Services.AddDbContext<ApiContext>
    (opt => opt.UseInMemoryDatabase("ApiDb"));

