using EventBus.CatalogueServiceEvents.VehicleEvents;
using MassTransit;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Commands.VehicleCommands.DeleteVehicle;

public sealed class DeleteVehicleHandler(IPublishEndpoint publishEndpoint) : IRequestHandler<DeleteVehicleCommand>
{
    public async Task Handle(DeleteVehicleCommand command, CancellationToken cancellationToken)
    {
        await publishEndpoint.Publish(new VehicleDeleted(command.Id), cancellationToken);
    }
}