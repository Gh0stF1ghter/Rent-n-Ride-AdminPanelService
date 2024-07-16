using EventBus.CatalogueServiceEvents.VehicleEvents;
using Mapster;
using MassTransit;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Commands.VehicleCommands.UpdateVehicle;

public sealed class UpdateVehicleHandler(IPublishEndpoint publishEndpoint) : IRequestHandler<UpdateVehicleCommand>
{
    public async Task Handle(UpdateVehicleCommand command, CancellationToken cancellationToken)
    {
        var carModelToUpdate = command.UpdatedModel.Adapt<VehicleUpdated>();

        await publishEndpoint.Publish(carModelToUpdate, cancellationToken);
    }
}