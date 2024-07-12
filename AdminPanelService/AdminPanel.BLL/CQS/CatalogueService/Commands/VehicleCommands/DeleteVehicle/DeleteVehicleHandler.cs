using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Commands.VehicleCommands.DeleteVehicle;

public sealed class DeleteVehicleHandler : IRequestHandler<DeleteVehicleCommand>
{
    public Task Handle(DeleteVehicleCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}