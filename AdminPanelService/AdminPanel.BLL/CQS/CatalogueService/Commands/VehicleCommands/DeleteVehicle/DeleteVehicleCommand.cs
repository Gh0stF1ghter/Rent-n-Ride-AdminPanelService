using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Commands.VehicleCommands.DeleteVehicle;

public sealed record DeleteVehicleCommand(Guid Id) : IRequest;