using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Commands.VehicleCommands.UpdateVehicle;

public sealed record UpdateVehicleCommand(VehicleModel UpdatedModel) : IRequest<VehicleModel>;