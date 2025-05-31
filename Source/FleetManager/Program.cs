using Microsoft.AspNetCore.Builder;

namespace FleetManager;

public static class Program
{
  public static void Main()
  {
    var app = new Startup().Build();

    app.MapGet("/", () => "Hello World!");
    app.UseSwagger();
    app.UseSwaggerUI();

    app.Run();
  }
}
