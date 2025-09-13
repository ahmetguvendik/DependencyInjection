using ConsoleApp1;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddScoped<IOgretmen, Ogretmen>();

