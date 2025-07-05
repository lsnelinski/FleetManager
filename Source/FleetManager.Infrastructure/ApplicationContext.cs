using FleetManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.Infrastructure;

public class ApplicationContext : DbContext
{
  public DbSet<Vehicle> Vehicles { get; set; }
}
