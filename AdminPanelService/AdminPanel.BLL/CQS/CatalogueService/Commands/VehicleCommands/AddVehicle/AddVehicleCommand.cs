using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Commands.VehicleCommands.AddVehicle;

public sealed record AddVehicleCommand(VehicleModel NewModel) : IRequest;