using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FleetManager.Domain.Entities;

namespace FleetManager.Domain.Repositories;

public interface IVehicleRespository
{
  Task<IEnumerable<Vehicle>> GetAllVehiclesAsync(CancellationToken cancellationToken);
  Task<Vehicle> GetVehicleByIdAsync(int id, CancellationToken cancellationToken);
  Task<Vehicle> CreateVehicleAsync(Vehicle vehicle, CancellationToken cancellationToken);
  Task<Vehicle> UpdateVehicleByIdAsync(int id, Vehicle vehicle, CancellationToken cancellationToken);
  Task<Vehicle> DeleteVehicleByIdAsync(int id, CancellationToken cancellationToken);
}
