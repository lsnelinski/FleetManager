using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FleetManager.Domain.Entities;
using FleetManager.Domain.Repositories;
using Microsoft.Extensions.Logging;

namespace FleetManager.Infrastructure.Repositories;

public class VehicleRepository : IVehicleRespository
{
  private readonly ApplicationContext _applicationContext;
  private readonly ILogger<VehicleRepository> _logger;

  public VehicleRepository(ApplicationContext applicationContext, ILogger<VehicleRepository> logger)
  {
    _applicationContext = applicationContext;
    _logger = logger;
  }

  public async Task<IEnumerable<Vehicle>> GetAllVehiclesAsync(CancellationToken cancellationToken)
  {
    throw new NotImplementedException();
  }

  public async Task<Vehicle> GetVehicleByIdAsync(int id, CancellationToken cancellationToken)
  {
    throw new NotImplementedException();
  }

  public async Task<Vehicle> CreateVehicleAsync(Vehicle vehicle, CancellationToken cancellationToken)
  {
    throw new NotImplementedException();
  }

  public async Task<Vehicle> UpdateVehicleByIdAsync(int id, Vehicle vehicle, CancellationToken cancellationToken)
  {
    throw new NotImplementedException();
  }

  public async Task<Vehicle> DeleteVehicleByIdAsync(int id, CancellationToken cancellationToken)
  {
    throw new NotImplementedException();
  }
}
